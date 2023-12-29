using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NREditor
{
    public partial class Form1 : Form
    {
        private readonly Logger log = new Logger(String.Format("NREditor_log_{0}", DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss")), ConfigurationManager.AppSettings["logPath"]);

        private string moveToOld;
        //potential overload, but should be fine for this project
        private int ID = 0;
        private int recordCount = 0;
        private int lastStartingIndex = 1;

        public Form1()
        {
            string[] UserList = ConfigurationManager.AppSettings["permittedUsers"].Split(',');
            if (Login(UserList, Environment.UserName))
            {
                InitializeComponent();
                //ClearForm();
                StyleGrid();
                DisplayData();
            }
            else
                MessageBox.Show("Не авторизований користувач!");
        }

        public void StyleGrid()
        {
            gridTable.ReadOnly = true;
            gridTable.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
            gridTable.RowsDefaultCellStyle.BackColor = Color.FromArgb(195, 199, 209);//Color.BlanchedAlmond;
            //dataGridView1.RowsDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 8);
            gridTable.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            //dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            gridTable.DefaultCellStyle.SelectionBackColor = Color.FromArgb(92, 148, 148);
            gridTable.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridTable.BackgroundColor = Color.FromArgb(255, 255, 255);
            gridTable.EnableHeadersVisualStyles = false;
            gridTable.ColumnHeadersDefaultCellStyle.Font = new Font("MS Reference Sans Serif", 10);
            gridTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridTable.ColumnHeadersHeight = 30;
            gridTable.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 71, 97);
            gridTable.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        //Display data in DataGridView 
        private void DisplayData()
        {
            using (SqlConnection sqlCon = new SqlConnection(ConnectionStrings.connectionString))
            {
                string query = 
                    $"SELECT TOP(1) ID " +
                    $"FROM {ConfigurationManager.AppSettings["tableName"]}" +
                    $" ORDER BY ID DESC";
                using (SqlCommand cmdCount = new SqlCommand(query, sqlCon))
                    recordCount = (int)cmdCount.ExecuteScalar();
            }

            RequestFromDB((tbMoveTo.Text == "" ? 1 : Int32.Parse(tbMoveTo.Text)), Int32.Parse(cmbStep.Text));
            
            //DataTable dt = new DataTable();
            //adapt = new SqlDataAdapter($"SELECT TOP ({step}) ID, Phone, AgId, DateStart, ResCall1, ResCall2, FName, CallRegion, txtReg, IDP, ChildrenNum, ChildrenWithDisabilities, Food, Dwelling, Work, Education, Medicine, Other, OtherComment, Comment from {tableName} where AgID > 0 and ID <= {recordCount} and ID > {recordCount} - {step} order by ID desc", con);
            //lblRecords.Text = $"{recordCount - step} - {recordCount}";
            //adapt.Fill(dt);
            //dataGridView1.DataSource = dt;
            //con.Close();

            for (int i = 0; i < gridTable.Columns.Count; i++)
            {
                gridTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                int colW = gridTable.Columns[i].Width;
                gridTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                gridTable.Columns[i].Width = colW;
            }
        }

        //Maybe should create a bulk copy of a table from db, so i wouldn't use connection every time i need to get something from db
        //This way it may be more resource efficient if i just store info in copy and filter it as i need to
        private void RequestFromDB(int startingValue, int step)
        {
            string query = $"SELECT TOP ({step}) ID, DateStart, AgId, DestinationNumb" +
                    $"er, Uneff, Phone, FName, txtReg, txtCityName, ResCall1, ResCall2, ResCall3, ResComment " +
                    $"FROM {ConfigurationManager.AppSettings["tableName"]} " +
                    $"WHERE AgID > 0 and ID >= {startingValue} " +
                    $"ORDER BY ID ASC";

            using (SqlConnection sqlCon = new SqlConnection(ConnectionStrings.connectionString))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter adapt = new SqlDataAdapter(query, sqlCon))// and ID < {startingValue} + {step}
                {
                    lblRecords.Text = $"{startingValue} - {startingValue + step}";
                    adapt.Fill(dt);
                }
                gridTable.DataSource = dt;
            }

            if (startingValue > 1)
                btnPrevRecords.Enabled = true;
            else
                btnPrevRecords.Enabled = false;

            if ((startingValue + step) >= recordCount)
                btnNextRecords.Enabled = false;
            else
                btnNextRecords.Enabled = true;

            lastStartingIndex = startingValue;
        }

        //Using a simple user login check
        //Access is given to users, whose login is in list (list is stored in config file)
        private bool Login(string[] UserList, string User)
        {
            if (UserList.Contains(User))
                return true;
            else
                return false;
        }

        private void ClearForm()
        {
            dtDate.CustomFormat = "";
            dtDate.Format = DateTimePickerFormat.Custom;
            tbAgID.Text = "";
            tbLine.Text = "";

            cmbCategory.Text = "";
            cmbCategory.SelectedIndex = -1;
            tbPhone.Text = "";
            tbName.Text = "";

            cmbRegion.Text = "";
            cmbRegion.SelectedIndex = -1;
            tbCity.Text = "";

            cmbType.Text = "";
            cmbType.SelectedIndex = -1;
            cmbSubtype1.Text = "";
            cmbSubtype1.SelectedIndex = -1;
            cmbSubtype2.Text = "";
            cmbSubtype2.SelectedIndex = -1;

            tbComment.Text = "";
            ID = 0;

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbAgID.Text != "" && tbLine.Text != "" && cmbCategory.Text != "" && tbPhone.Text != "" && tbName.Text != "" && cmbRegion.Text != "" && tbCity.Text != "" &&
                cmbType.Text != "" && cmbSubtype1.Text != "" && cmbSubtype2.Text != "")
            {
                int modified = 0;
                string query = $"INSERT INTO {ConfigurationManager.AppSettings["tableName"]}" +
                        $"(DateStart, AgID, DestinationNumber, Uneff, Phone, FName, txtReg, txtCityName, ResCall1, ResCall2, ResCall3, ResComment) " +
                        $"OUTPUT INSERTED.ID " +
                        $"VALUES" +
                        $"(@date, @agid, @line, @category, @phone, @fname, @txtreg, @city, @type, @subtype1, @subtype2, @comment)";

                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(ConnectionStrings.connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {

                            cmd.Parameters.AddWithValue("@date", dtDate.Value);
                            cmd.Parameters.AddWithValue("@agid", tbAgID.Text);
                            cmd.Parameters.AddWithValue("@line", tbLine.Text);
                            cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                            cmd.Parameters.AddWithValue("@fname", tbName.Text);
                            cmd.Parameters.AddWithValue("@txtreg", cmbRegion.Text);
                            cmd.Parameters.AddWithValue("@city", tbCity.Text);
                            cmd.Parameters.AddWithValue("@type", cmbType.Text);
                            cmd.Parameters.AddWithValue("@subtype1", cmbSubtype1.Text);
                            cmd.Parameters.AddWithValue("@subtype2", cmbSubtype2.Text);
                            cmd.Parameters.AddWithValue("@comment", tbComment.Text);


                            modified = (int)cmd.ExecuteScalar();
                        }
                    }

                    DisplayData();
                    ClearForm();
                    MessageBox.Show($"Запис успішно додано! ID запису {modified}");
                } catch (Exception ex)
                {
                    log.WriteLine("An error occured while inserting data! Error message: " + ex.Message);
                    MessageBox.Show("Сталась помилка при спробі створити запис! Текст помилки: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Заповніть дані для внесення в таблицю!");
            }
        }

        //Should use transactions here
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (tbAgID.Text != "" && tbLine.Text != "" && cmbCategory.Text != "" && tbPhone.Text != "" && tbName.Text != "" && cmbRegion.Text != "" && tbCity.Text != "" && 
                cmbType.Text != "" && cmbSubtype1.Text != "" && cmbSubtype2.Text != "")
            {
                try
                {
                    using (SqlConnection sqlCon = new SqlConnection(ConnectionStrings.connectionString))
                    {
                        string query = $"UPDATE {ConfigurationManager.AppSettings["tableName"]} " +
                            $"SET AgID = @agid, DestinationNumber = @line, Uneff = @category, Phone = @phone, FName = @name, txtReg = @txtreg, " +
                            $"txtCityName = @city, ResCall1 = @type, ResCall2 = @subtype1, ResCall3 = @subtype2, ResComment = @comment " +
                            $"WHERE ID = @id";

                        using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                        {
                            cmd.Parameters.AddWithValue("@id", ID);
                            cmd.Parameters.AddWithValue("@agid", tbAgID.Text);
                            cmd.Parameters.AddWithValue("@line", tbLine.Text);
                            cmd.Parameters.AddWithValue("@category", cmbCategory.Text);
                            cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                            cmd.Parameters.AddWithValue("@name", tbName.Text);
                            cmd.Parameters.AddWithValue("@txtreg", cmbRegion.Text);
                            cmd.Parameters.AddWithValue("@city", tbCity.Text);
                            cmd.Parameters.AddWithValue("@type", cmbType.Text);
                            cmd.Parameters.AddWithValue("@subtype1", cmbSubtype1.Text);
                            cmd.Parameters.AddWithValue("@subtype2", cmbSubtype2.Text);
                            cmd.Parameters.AddWithValue("@comment", tbComment.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    DisplayData();
                    ClearForm();
                } catch (Exception ex)
                {
                    log.WriteLine("An error occured while updating data! Error message: " + ex.Message);
                    MessageBox.Show("Сталась помилка при спробі оновити дані! Текст помилки: " + ex.Message);
                }

                MessageBox.Show("Запис успішно змінено!");
            }
            else
            {
                MessageBox.Show("Внесіть коректні дані для внесення змін!");
            }
        }

        //Should use transactions here
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Ви впевнені що хочете видалити запис {ID}?", "Видалення", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string query = $"UPDATE {ConfigurationManager.AppSettings["tableName"]} " +
                                $"SET AgID = -@agid " +
                                $"WHERE ID = @id";
                        using (SqlConnection sqlCon = new SqlConnection(ConnectionStrings.connectionString))
                        {
                            using (SqlCommand cmd = new SqlCommand(query, sqlCon))//delete from {tableName} where ID = @id
                            {
                                cmd.Parameters.AddWithValue("@id", ID);
                                cmd.Parameters.AddWithValue("@agid", Int32.Parse(tbAgID.Text));
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Запис успішно видалено!");
                        DisplayData();
                        ClearForm();
                    } catch (Exception ex)
                    {
                        log.WriteLine("An error occured while deleting a record! Error message: " + ex.Message);
                        MessageBox.Show("Сталась помилка при спробі видалення запису! Текст помилки: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Спочатку оберіть запис для видалення!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnUpdate.BtnPrevColor = btnUpdate.BackgroundColor;
            btnUpdate.Enabled = false;
            btnDelete.BtnPrevColor = btnDelete.BackgroundColor;
            btnDelete.Enabled = false;
            btnPrevRecords.Enabled = false;
        }

        private void gridTable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridTable.Rows[e.RowIndex].Cells[0].Value.ToString() != "")
            {
                ID = Convert.ToInt32(gridTable.Rows[e.RowIndex].Cells[0].Value.ToString());
                dtDate.Value = (DateTime)gridTable.Rows[e.RowIndex].Cells[1].Value;
                tbAgID.Text = gridTable.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbLine.Text = gridTable.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbCategory.Text = gridTable.Rows[e.RowIndex].Cells[4].Value.ToString();
                tbPhone.Text = gridTable.Rows[e.RowIndex].Cells[5].Value.ToString();
                tbName.Text = gridTable.Rows[e.RowIndex].Cells[6].Value.ToString();
                cmbRegion.Text = gridTable.Rows[e.RowIndex].Cells[7].Value.ToString();
                tbCity.Text = gridTable.Rows[e.RowIndex].Cells[8].Value.ToString();
                cmbType.Text = gridTable.Rows[e.RowIndex].Cells[9].Value.ToString();
                cmbSubtype1.Text = gridTable.Rows[e.RowIndex].Cells[10].Value.ToString();
                cmbSubtype2.Text = gridTable.Rows[e.RowIndex].Cells[11].Value.ToString();
                tbComment.Text = gridTable.Rows[e.RowIndex].Cells[12].Value.ToString();

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
                ClearForm();
        }

        private void gridTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearForm();
        }

        private void cmbStep_TextChanged(object sender, EventArgs e)
        {
            //if (cmbStep.Text != "")
            //{
            //    if (tbMoveTo.Text == "")
            //        RequestFromDB(1, Int32.Parse(cmbStep.Text));
            //    else
            //        RequestFromDB(Int32.Parse(tbMoveTo.Text), Int32.Parse(cmbStep.Text));
            //}
            if (cmbStep.Text == "")
            {
                MessageBox.Show("Поле не можна залишати порожнім!");
                cmbStep.Text = "100";
            }
        }

        private void tbMoveTo_TextChanged(object sender, EventArgs e)
        {
            if (tbMoveTo.Text != "")
            {
                if (Int32.Parse(tbMoveTo.Text) < recordCount)
                {
                    RequestFromDB(Int32.Parse(tbMoveTo.Text), Int32.Parse(cmbStep.Text));
                    moveToOld = tbMoveTo.Text;
                }
                else
                {
                    MessageBox.Show("Значення не може перевищувати кількість записів у таблиці!");
                    tbMoveTo.Text = moveToOld;
                }
            }
            else
                RequestFromDB(1, Int32.Parse(cmbStep.Text));
        }

        private void btnPrevRecords_Click(object sender, EventArgs e)
        {
            if (!((lastStartingIndex - Int32.Parse(cmbStep.Text)) < 1))
                RequestFromDB(lastStartingIndex - Int32.Parse(cmbStep.Text), Int32.Parse(cmbStep.Text));
            else
                RequestFromDB(1, Int32.Parse(cmbStep.Text));

            ClearForm();
        }

        private void btnNextRecords_Click(object sender, EventArgs e)
        {
            RequestFromDB(lastStartingIndex + Int32.Parse(cmbStep.Text), Int32.Parse(cmbStep.Text));

            ClearForm();
        }
    }
}
