using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReader
{
    public partial class FormConfiguration : Form
    {
        DataTable filePathInfo = new DataTable();
        DataTable configuration = null;
        List<string> searchColumns = null;

        public FormConfiguration()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            filePathInfo.Columns.Add("Name");
            filePathInfo.Columns.Add("FullName");
            this.WindowState = FormWindowState.Maximized;
            this.btn_Search.Enabled = false;
            this.cmb_Environment.DataSource = new List<string> { "Production", "Pirun" };
        }

        private void cmb_Environment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                filePathInfo.Clear();
                string filePath = ConfigurationManager.AppSettings[cmb_Environment.Text];
                DirectoryInfo directoryInfo = new DirectoryInfo(filePath);
                FileInfo[] files = directoryInfo.GetFiles("*.csv", SearchOption.TopDirectoryOnly);
                foreach (var file in files)
                {
                    filePathInfo.Rows.Add(file.Name, file.FullName);
                }
                cmb_FileList.DataSource = filePathInfo;
                cmb_FileList.DisplayMember = "Name";
                cmb_FileList.ValueMember = "FullName";
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string fullName = cmb_FileList.SelectedValue.ToString();
                configuration = new DataTable();
                searchColumns = new List<string>();
                FileStream fs = new FileStream(fullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                using (StreamReader sr = new StreamReader(fs))
                {
                    string readLine = "";
                    bool isFirst = true;
                    while ((readLine = sr.ReadLine()) != null)
                    {
                        string[] array = readLine.Split(',');
                        if (isFirst)
                        {
                            for (int i = 0; i < array.Length; i++)
                            {
                                configuration.Columns.Add(array[i]);
                                searchColumns.Add(array[i]);
                            }
                            isFirst = false;
                        }
                        else
                        {
                            configuration.Rows.Add(array);
                        }
                    }
                }
                if (fs != null) fs.Dispose();
                this.btn_Search.Enabled = true;
                this.grd_Configuration.DataSource = configuration;
                this.cmb_SearchKey.DataSource = searchColumns;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string filter = string.Empty;
                DataView dv = new DataView(configuration.Copy());
                if (!string.IsNullOrEmpty(txt_SearchValue.Text))
                {
                    filter = string.Format("{0}='{1}'", cmb_SearchKey.Text, txt_SearchValue.Text);
                }
                dv.RowFilter = filter;
                DataTable dt = dv.ToTable();
                grd_Configuration.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (grd_Configuration.DataSource == null) return;
                DataTable dt = grd_Configuration.DataSource as DataTable;
                string path = cmb_FileList.SelectedValue as string;
                this.Export2CSV(dt, path);
                MessageBox.Show("Export Success");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        public void Export2CSV(DataTable table, string path)
        {
            bool flag = false;
            int count = table.Columns.Count;
            try
            {
                FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                try
                {
                    foreach (object obj in table.Columns)
                    {
                        DataColumn dataColumn = (DataColumn)obj;
                        if (!flag)
                        {
                            flag = true;
                        }
                        else
                        {
                            streamWriter.Write(',');
                        }
                        streamWriter.Write(dataColumn.ColumnName);
                    }
                    streamWriter.WriteLine();
                    foreach (object obj2 in table.Rows)
                    {
                        DataRow dataRow = (DataRow)obj2;
                        flag = false;
                        for (int i = 0; i < count; i++)
                        {
                            if (!flag)
                            {
                                flag = true;
                            }
                            else
                            {
                                streamWriter.Write(',');
                            }
                            streamWriter.Write(dataRow[i].ToString());
                        }
                        streamWriter.WriteLine();
                    }
                    streamWriter.Close();
                }
                finally
                {
                    if (streamWriter != null)
                    {
                        ((IDisposable)streamWriter).Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
