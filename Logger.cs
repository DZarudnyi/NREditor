using System;
using System.IO;


namespace NREditor
{
    public class Logger
    {
        private static readonly char DS = System.IO.Path.DirectorySeparatorChar;
        private string _path;
        private string _filename;
        private string _fullPath;


        public string Path
        {
            get => _path;
            set
            {
                string tempPath = value.Trim();
                if (tempPath != String.Empty)
                {
                    tempPath = System.IO.Path.GetDirectoryName($"{value}");
                }
                else
                {
                    tempPath = $"{System.IO.Directory.GetCurrentDirectory()}{DS}logs";
                }

                _path = $"{System.IO.Path.GetDirectoryName(tempPath+DS)}";
            }
        }

        public string FileName
        {
            get => _filename;
            set
            {
                string tempFilename = System.IO.Path.GetFileName(value);
                if (tempFilename.Trim() == String.Empty)
                {
                    throw new FormatException("Log filename is empty!");
                }

                if (System.IO.Path.GetExtension(tempFilename) == String.Empty)
                {
                    tempFilename = $"{tempFilename}.log";
                };
                _filename = tempFilename;
            }
        }

        /// <summary>
        /// Full path and filename of the current log file
        /// </summary>
        public string FullPath => _fullPath = $"{Path}{DS}{FileName}";


        public Logger(string logFileName = "", string logPath = "")
        {
            this.FileName = logFileName;
            this.Path = logPath;
        }

        /// <summary>
        /// Puts the text into a log file
        /// </summary>
        /// <param name="s">The text to put into the log file</param>
        private void WriteToFile(string s)
        {
            try
            {
                // creating directories if not exist
                System.IO.Directory.CreateDirectory(Path);
                FileInfo f = new FileInfo(FullPath);
                using (StreamWriter swriter = f.AppendText())
                {
                    if (s.Trim() == String.Empty)
                    {
                        swriter.WriteLine("");
                    }
                    else
                    {
                        swriter.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss:ffff} | {s}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot write log file! Error: " + e.Message);
            }
        }

        /// <summary>
        /// Outputs the text into console and inserts into log file
        /// </summary>
        /// <param name="s">Text to put into the log file</param>
        public void WriteLine(string s)
        {
            Console.WriteLine(s);
            WriteToFile(s);
        }

        public void Info(string s)
        {
            Console.WriteLine($"[INFO]: {s}");
            WriteToFile(s);
        }

        public void Error(string s)
        {
            Console.WriteLine($"[!]: {s}");
            WriteToFile(s);
        }

        public void Warning(string s)
        {
            Console.WriteLine($"[WRNG]: {s}");
            WriteToFile(s);
        }


        /// <summary>
        /// Inserts an empty line into the log file for readability
        /// </summary>
        public void InsertEmptyLine()
        {
            WriteLine(String.Empty);
        }
    }
}
