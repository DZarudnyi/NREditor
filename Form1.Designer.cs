
namespace NREditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnNextRecords = new System.Windows.Forms.Button();
            this.btnPrevRecords = new System.Windows.Forms.Button();
            this.tbMoveTo = new System.Windows.Forms.TextBox();
            this.lblMoveTo = new System.Windows.Forms.Label();
            this.cmbStep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRecords = new System.Windows.Forms.Label();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.gridTable = new System.Windows.Forms.DataGridView();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbLine = new System.Windows.Forms.TextBox();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new NREditor.NiceButtons();
            this.btnUpdate = new NREditor.NiceButtons();
            this.btnInsert = new NREditor.NiceButtons();
            this.tbAgID = new System.Windows.Forms.TextBox();
            this.lblAgID = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.lblComment = new System.Windows.Forms.Label();
            this.cmbSubtype2 = new System.Windows.Forms.ComboBox();
            this.cmbSubtype1 = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblSubtype2 = new System.Windows.Forms.Label();
            this.lblSubtype1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.cmbRegion = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlBottom.SuspendLayout();
            this.pnlTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnNextRecords);
            this.pnlBottom.Controls.Add(this.btnPrevRecords);
            this.pnlBottom.Controls.Add(this.tbMoveTo);
            this.pnlBottom.Controls.Add(this.lblMoveTo);
            this.pnlBottom.Controls.Add(this.cmbStep);
            this.pnlBottom.Controls.Add(this.label1);
            this.pnlBottom.Controls.Add(this.lblRecords);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 586);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1160, 51);
            this.pnlBottom.TabIndex = 4;
            // 
            // btnNextRecords
            // 
            this.btnNextRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnNextRecords.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNextRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnNextRecords.Image")));
            this.btnNextRecords.Location = new System.Drawing.Point(1109, 0);
            this.btnNextRecords.Name = "btnNextRecords";
            this.btnNextRecords.Size = new System.Drawing.Size(51, 51);
            this.btnNextRecords.TabIndex = 24;
            this.btnNextRecords.UseVisualStyleBackColor = false;
            this.btnNextRecords.Click += new System.EventHandler(this.btnNextRecords_Click);
            // 
            // btnPrevRecords
            // 
            this.btnPrevRecords.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevRecords.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrevRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevRecords.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrevRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevRecords.Image")));
            this.btnPrevRecords.Location = new System.Drawing.Point(0, 0);
            this.btnPrevRecords.Name = "btnPrevRecords";
            this.btnPrevRecords.Size = new System.Drawing.Size(51, 51);
            this.btnPrevRecords.TabIndex = 23;
            this.btnPrevRecords.UseVisualStyleBackColor = false;
            this.btnPrevRecords.Click += new System.EventHandler(this.btnPrevRecords_Click);
            // 
            // tbMoveTo
            // 
            this.tbMoveTo.Location = new System.Drawing.Point(909, 15);
            this.tbMoveTo.Name = "tbMoveTo";
            this.tbMoveTo.Size = new System.Drawing.Size(82, 20);
            this.tbMoveTo.TabIndex = 22;
            this.tbMoveTo.TextChanged += new System.EventHandler(this.tbMoveTo_TextChanged);
            // 
            // lblMoveTo
            // 
            this.lblMoveTo.AutoSize = true;
            this.lblMoveTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMoveTo.Location = new System.Drawing.Point(776, 17);
            this.lblMoveTo.Name = "lblMoveTo";
            this.lblMoveTo.Size = new System.Drawing.Size(138, 17);
            this.lblMoveTo.TabIndex = 6;
            this.lblMoveTo.Text = "Перейти до запису:";
            // 
            // cmbStep
            // 
            this.cmbStep.FormattingEnabled = true;
            this.cmbStep.Items.AddRange(new object[] {
            "50",
            "100",
            "200",
            "500",
            "1000"});
            this.cmbStep.Location = new System.Drawing.Point(665, 16);
            this.cmbStep.Name = "cmbStep";
            this.cmbStep.Size = new System.Drawing.Size(61, 21);
            this.cmbStep.TabIndex = 5;
            this.cmbStep.Text = "100";
            this.cmbStep.TextChanged += new System.EventHandler(this.cmbStep_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(625, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Крок:";
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecords.AutoSize = true;
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRecords.Location = new System.Drawing.Point(429, 17);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(45, 17);
            this.lblRecords.TabIndex = 2;
            this.lblRecords.Text = "1-100";
            // 
            // pnlTable
            // 
            this.pnlTable.Controls.Add(this.gridTable);
            this.pnlTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTable.Location = new System.Drawing.Point(0, 197);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(1160, 389);
            this.pnlTable.TabIndex = 8;
            // 
            // gridTable
            // 
            this.gridTable.AllowUserToAddRows = false;
            this.gridTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTable.Location = new System.Drawing.Point(0, 0);
            this.gridTable.Name = "gridTable";
            this.gridTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridTable.Size = new System.Drawing.Size(1160, 389);
            this.gridTable.TabIndex = 2;
            this.gridTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTable_CellClick);
            this.gridTable.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridTable_RowHeaderMouseClick);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbCity);
            this.pnlMain.Controls.Add(this.tbName);
            this.pnlMain.Controls.Add(this.tbLine);
            this.pnlMain.Controls.Add(this.dtDate);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.btnInsert);
            this.pnlMain.Controls.Add(this.tbAgID);
            this.pnlMain.Controls.Add(this.lblAgID);
            this.pnlMain.Controls.Add(this.tbComment);
            this.pnlMain.Controls.Add(this.lblComment);
            this.pnlMain.Controls.Add(this.cmbSubtype2);
            this.pnlMain.Controls.Add(this.cmbSubtype1);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.cmbCategory);
            this.pnlMain.Controls.Add(this.tbPhone);
            this.pnlMain.Controls.Add(this.lblSubtype2);
            this.pnlMain.Controls.Add(this.lblSubtype1);
            this.pnlMain.Controls.Add(this.lblType);
            this.pnlMain.Controls.Add(this.lblName);
            this.pnlMain.Controls.Add(this.lblPhone);
            this.pnlMain.Controls.Add(this.lblCategory);
            this.pnlMain.Controls.Add(this.lblLine);
            this.pnlMain.Controls.Add(this.cmbRegion);
            this.pnlMain.Controls.Add(this.lblDate);
            this.pnlMain.Controls.Add(this.lblRegion);
            this.pnlMain.Controls.Add(this.lblCity);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1160, 197);
            this.pnlMain.TabIndex = 7;
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(556, 61);
            this.tbCity.MaxLength = 150;
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(170, 20);
            this.tbCity.TabIndex = 43;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(943, 36);
            this.tbName.MaxLength = 100;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(188, 20);
            this.tbName.TabIndex = 42;
            // 
            // tbLine
            // 
            this.tbLine.Location = new System.Drawing.Point(943, 8);
            this.tbLine.MaxLength = 50;
            this.tbLine.Name = "tbLine";
            this.tbLine.Size = new System.Drawing.Size(188, 20);
            this.tbLine.TabIndex = 41;
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(153, 8);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(170, 20);
            this.dtDate.TabIndex = 40;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnDelete.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDelete.BorderRadius = 20;
            this.btnDelete.BorderSize = 0;
            this.btnDelete.BtnPrevColor = System.Drawing.Color.Empty;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(820, 145);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.TabIndex = 39;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.TextColor = System.Drawing.Color.White;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnUpdate.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnUpdate.BorderRadius = 20;
            this.btnUpdate.BorderSize = 0;
            this.btnUpdate.BtnPrevColor = System.Drawing.Color.Empty;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(506, 145);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Змінити дані";
            this.btnUpdate.TextColor = System.Drawing.Color.White;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.ForestGreen;
            this.btnInsert.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnInsert.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnInsert.BorderRadius = 20;
            this.btnInsert.BorderSize = 0;
            this.btnInsert.BtnPrevColor = System.Drawing.Color.Empty;
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(209, 145);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(150, 40);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "Додати";
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbAgID
            // 
            this.tbAgID.Location = new System.Drawing.Point(556, 8);
            this.tbAgID.MaxLength = 6;
            this.tbAgID.Name = "tbAgID";
            this.tbAgID.Size = new System.Drawing.Size(100, 20);
            this.tbAgID.TabIndex = 37;
            // 
            // lblAgID
            // 
            this.lblAgID.AutoSize = true;
            this.lblAgID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgID.Location = new System.Drawing.Point(454, 9);
            this.lblAgID.Name = "lblAgID";
            this.lblAgID.Size = new System.Drawing.Size(96, 17);
            this.lblAgID.TabIndex = 36;
            this.lblAgID.Text = "ID оператора";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(153, 117);
            this.tbComment.MaxLength = 1000;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(978, 20);
            this.tbComment.TabIndex = 35;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblComment.Location = new System.Drawing.Point(74, 120);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(73, 17);
            this.lblComment.TabIndex = 34;
            this.lblComment.Text = "Коментар";
            // 
            // cmbSubtype2
            // 
            this.cmbSubtype2.FormattingEnabled = true;
            this.cmbSubtype2.Items.AddRange(new object[] {
            "Склад",
            "Термін зберігання",
            "Наявність у магазині",
            "Інше",
            "Графік роботи",
            "Адреса",
            "Співпраця",
            "Акції",
            "Про виробника",
            "Інше",
            "Умови",
            "Реєстрація",
            "Уточнення даних по карті",
            "Додаток",
            "Інше"});
            this.cmbSubtype2.Location = new System.Drawing.Point(943, 89);
            this.cmbSubtype2.Name = "cmbSubtype2";
            this.cmbSubtype2.Size = new System.Drawing.Size(188, 21);
            this.cmbSubtype2.TabIndex = 26;
            // 
            // cmbSubtype1
            // 
            this.cmbSubtype1.FormattingEnabled = true;
            this.cmbSubtype1.Items.AddRange(new object[] {
            "Продукт",
            "Сервіс",
            "Програма лояльності",
            "Інше"});
            this.cmbSubtype1.Location = new System.Drawing.Point(556, 89);
            this.cmbSubtype1.Name = "cmbSubtype1";
            this.cmbSubtype1.Size = new System.Drawing.Size(170, 21);
            this.cmbSubtype1.TabIndex = 25;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Консультація",
            "Реєстрація звернення",
            "CallBack по втраченому дзвінку",
            "Переключення на співробітника"});
            this.cmbType.Location = new System.Drawing.Point(153, 90);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(170, 21);
            this.cmbType.TabIndex = 24;
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Ефективний дзвінок",
            "Неефективний дзвінок"});
            this.cmbCategory.Location = new System.Drawing.Point(153, 35);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(170, 21);
            this.cmbCategory.TabIndex = 22;
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(556, 35);
            this.tbPhone.MaxLength = 20;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(170, 20);
            this.tbPhone.TabIndex = 19;
            // 
            // lblSubtype2
            // 
            this.lblSubtype2.AutoSize = true;
            this.lblSubtype2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubtype2.Location = new System.Drawing.Point(873, 90);
            this.lblSubtype2.Name = "lblSubtype2";
            this.lblSubtype2.Size = new System.Drawing.Size(64, 17);
            this.lblSubtype2.TabIndex = 12;
            this.lblSubtype2.Text = "Підтип 2";
            // 
            // lblSubtype1
            // 
            this.lblSubtype1.AutoSize = true;
            this.lblSubtype1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSubtype1.Location = new System.Drawing.Point(486, 90);
            this.lblSubtype1.Name = "lblSubtype1";
            this.lblSubtype1.Size = new System.Drawing.Size(64, 17);
            this.lblSubtype1.TabIndex = 11;
            this.lblSubtype1.Text = "Підтип 1";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblType.Location = new System.Drawing.Point(58, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(89, 17);
            this.lblType.TabIndex = 10;
            this.lblType.Text = "Тип виклику";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblName.Location = new System.Drawing.Point(906, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Ім\'я";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPhone.Location = new System.Drawing.Point(482, 36);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(68, 17);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Телефон";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCategory.Location = new System.Drawing.Point(23, 36);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(124, 17);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Категорія дзвінка";
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLine.Location = new System.Drawing.Point(897, 9);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(40, 17);
            this.lblLine.TabIndex = 6;
            this.lblLine.Text = "Лінія";
            // 
            // cmbRegion
            // 
            this.cmbRegion.FormattingEnabled = true;
            this.cmbRegion.Items.AddRange(new object[] {
            "Закарпатська",
            "Львiвська",
            "Волинська",
            "Івано-Франківська",
            "Тернопільська",
            "Рiвненська",
            "Чернівецька",
            "Хмельницька",
            "Житомирська",
            "Вiнницька",
            "Київська",
            "Чернігівська",
            "Черкаська",
            "Одеська",
            "Миколаївська",
            "Кіровоградська",
            "Полтавська",
            "Сумська",
            "Херсонська",
            "Днiпропетровська",
            "Харківська",
            "Запорiзька",
            "Донецька",
            "Луганська",
            "АР Крим"});
            this.cmbRegion.Location = new System.Drawing.Point(153, 62);
            this.cmbRegion.Name = "cmbRegion";
            this.cmbRegion.Size = new System.Drawing.Size(170, 21);
            this.cmbRegion.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDate.Location = new System.Drawing.Point(53, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 17);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Дата дзвінка";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRegion.Location = new System.Drawing.Point(83, 63);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(64, 17);
            this.lblRegion.TabIndex = 2;
            this.lblRegion.Text = "Область";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCity.Location = new System.Drawing.Point(506, 62);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(44, 17);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "Місто";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 197);
            this.panel2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 637);
            this.Controls.Add(this.pnlTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NR Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.pnlTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridTable)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblRecords;
        private System.Windows.Forms.ComboBox cmbStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMoveTo;
        private System.Windows.Forms.Label lblMoveTo;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.DataGridView gridTable;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbAgID;
        private System.Windows.Forms.Label lblAgID;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.ComboBox cmbSubtype2;
        private System.Windows.Forms.ComboBox cmbSubtype1;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblSubtype2;
        private System.Windows.Forms.Label lblSubtype1;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.ComboBox cmbRegion;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnNextRecords;
        private System.Windows.Forms.Button btnPrevRecords;
        private NiceButtons btnDelete;
        private NiceButtons btnUpdate;
        private NiceButtons btnInsert;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.TextBox tbLine;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbCity;
    }
}

