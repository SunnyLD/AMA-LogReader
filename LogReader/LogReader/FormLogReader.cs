using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Xml;
using TIBCO.Rendezvous;
using System.Threading;

namespace LogReader
{
    public partial class FormLogReader : Form
    {

        #region FormLogReader
        public FormLogReader()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Variable
        private DataTable LogList;
        private CultureInfo culture;
        private const string dtFormat = "yyyy-MM-dd HH:mm:ss.ff";
        private string localLogPath;
        private string remoteLogPath;
        private string prefix;
        private string backupLogPath;

        //RV Setting
        private string service;
        private string network;
        private string daemon;
        private string listenSubject;
        private string targetSubject;
        private double timeOut;
        private string setEncoding;
        private NetTransport netTtransport;
        private Queue queue;
        private Dispatcher dispatcher;
        private Listener listener;
        private object lockObject=new object();
        private int maxCount = 10000;
        private object lockOfLogList = new object();


        #endregion

        #region Private Event
        private void FormLogReader_Load(object sender, EventArgs e)
        {
            culture = CultureInfo.CreateSpecificCulture("en-US");
            LogList = this.SetLogList();
            dtpEndTime.Value = DateTime.Now;
            dtpStartTime.Value = DateTime.Now.AddHours(-1);
            this.WindowState = FormWindowState.Maximized;
            this.cmbEnvironment.DataSource = new List<string> { "Production", "Pirun" };
            this.Text = "Reader-" + System.Environment.CurrentDirectory;
            this.timer1.Start();
            #region RV Setting
            service = ConfigurationManager.AppSettings["Service"];
            network = ConfigurationManager.AppSettings["Network"];
            daemon = ConfigurationManager.AppSettings["Daemon"];
            listenSubject = ConfigurationManager.AppSettings["ListenSubject"];
            timeOut = Convert.ToDouble(ConfigurationManager.AppSettings["Timeout"]);
            setEncoding = ConfigurationManager.AppSettings["Encoding"];
            targetSubject = ConfigurationManager.AppSettings["TragetSubject"];
            #endregion
            maxCount = Convert.ToInt32(ConfigurationManager.AppSettings["MaxCount"]);     
        }

        private void cmbEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbEnvironment.Text)) return;
            localLogPath = System.Environment.CurrentDirectory + string.Format(@"\Logs\{0}\", cmbEnvironment.Text);
            backupLogPath = System.Environment.CurrentDirectory + string.Format(@"\Logs\Backup\{0}\", cmbEnvironment.Text);
            if (!Directory.Exists(localLogPath))
            {
                Directory.CreateDirectory(localLogPath);
            }
            remoteLogPath = ConfigurationManager.AppSettings[cmbEnvironment.Text + "RemoteDirectory"];
            prefix = ConfigurationManager.AppSettings[cmbEnvironment.Text + "Prefix"];
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(remoteLogPath)) return;
                string[] directorys = remoteLogPath.Split(';');
                string[] prefixs = prefix.Split(';');
                if (directorys.Length <= 0 || directorys.Length != prefixs.Length)
                {
                    MessageBox.Show("Setting Error!");
                    return;
                }
                if (cbx_Backup.Checked)
                {
                    this.BackupLog();
                }
                for (int i = 0; i < directorys.Length; i++)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(directorys[i]);
                    FileInfo[] files = directoryInfo.GetFiles();
                    var selected = files.Where(p => p.LastWriteTime <= dtpEndTime.Value
                    && dtpStartTime.Value <= p.LastWriteTime).ToList();
                    foreach (var file in selected)
                    {
                        File.Copy(file.FullName, localLogPath + prefixs[i] + file.Name, true);
                    }
                }
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

        private void btn_Open_Click(object sender, EventArgs e)
        {
            try
            {
                var openDialog = new OpenFileDialog();
                LogList.Clear();
                openDialog.Multiselect = true;
                openDialog.InitialDirectory = @localLogPath;
                if (openDialog.ShowDialog() != DialogResult.OK) return;
                string[] fileNames = openDialog.FileNames;
                foreach (var fileName in fileNames)
                {
                    this.ReadLogFile(fileName);
                }
                lock (lockOfLogList) grid_LogList.DataSource = LogList.Copy(); 
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

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (LogList.Rows.Count <= 0) return;
                string filter = this.SetFilter();
                lock (lockOfLogList)
                {
                    if (!string.IsNullOrEmpty(filter))
                    {
                        using (DataView dv = new DataView(LogList.Copy()))
                        {
                            dv.RowFilter = filter;
                            DataTable dt = dv.ToTable();
                            grid_LogList.DataSource = dt; //SortLogInfo(dt);
                        }
                        this.Logging("Search Filter:" + filter);
                    }
                    else
                    {
                        grid_LogList.DataSource = LogList.Copy();
                    }
                    GC.Collect();
                }
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            this.LogList.Dispose();
            this.grid_LogList.DataSource = LogList;
            this.Logging("Clear");
            LogList.Clear();
            GC.Collect();
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (this.grid_LogList.DataSource != null)
                {
                    DataTable dt = this.grid_LogList.DataSource as DataTable;
                    SaveFileDialog dialog = new SaveFileDialog();
                    dialog.InitialDirectory = "C:\\Users\\b2mesdtest\\Desktop\\";
                    dialog.Filter = "Excel File(*.csv)|";
                    dialog.DefaultExt = ".csv";
                    dialog.AddExtension = true;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        bool exeResult = UtilExcel.DataTableToExcelFile(dt, dialog.FileName);
                        if (exeResult)
                        {
                            string message = string.Format("Export {0} Success", dialog.FileName);
                            MessageBox.Show(message, "Export");
                        }
                    }
                }
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void grid_LogList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0 || e.RowIndex < 0) return;
            FormMessage frm = new FormMessage();
            if (ckb_AutoMatch.Checked)
            {
                string subExecId = grid_LogList.Rows[e.RowIndex].Cells["SubJobExecId"].Value.ToString();
                string execJobName = grid_LogList.Rows[e.RowIndex].Cells["ExecJobName"].Value.ToString();
                DataTable dt = LogList.Copy();
                var tmpSend = dt.AsEnumerable().Where(p =>
                 {
                     return p["SubJobExecId"].ToString() == subExecId
                     && p["ExecJobName"].ToString() == execJobName
                     && p["ExecJobStatus"].ToString().Contains("Send_Info");
                 }).ToList();
                string sendInfo = tmpSend.Count > 0 ? FormatMessage(tmpSend[0]["TraceInfo"].ToString()) : string.Empty;

                var tmpReply = dt.AsEnumerable().Where(p =>
                {
                    return p["SubJobExecId"].ToString() == subExecId
                    && p["ExecJobName"].ToString() == execJobName
                    && p["ExecJobStatus"].ToString().Contains("Reply_Info");
                }).ToList();
                string replyInfo = tmpReply.Count > 0 ? FormatMessage(tmpReply[0]["TraceInfo"].ToString()) : string.Empty;
                frm.SendMessage = sendInfo;
                frm.ReplyMessage = replyInfo;

            }
            else
            {
                string info = grid_LogList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                frm.SendMessage = FormatMessage(info);
            }
            frm.AutoMatchFlag = ckb_AutoMatch.Checked;
            frm.ShowDialog();
        }

        private void grid_LogList_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "TimeStamp":
                case "ExecJobName":
                case "TraceInfo":
                    e.Column.MinimumWidth = 180;
                    break;
                case "LogLevel":
                    e.Column.Visible = false;
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void item_Configuration_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                FormConfiguration frm = new FormConfiguration();
                //frm.Parent = this;
                frm.Show();
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_Connect.Text == "DisConnect")
                {
                    this.StopConnecting();
                    this.btn_Connect.Text = "Connect RV";
                    //isRvConnected = false;
                    return;
                }
                if (string.IsNullOrEmpty(listenSubject))
                {
                    MessageBox.Show("Set Listen or Target Subject First", "Error");
                    return;
                }
                if (!string.IsNullOrEmpty(setEncoding))
                {
                    Encoding encoding = System.Text.Encoding.GetEncoding(setEncoding);
                    TIBCO.Rendezvous.Environment.StringEncoding = encoding;
                }
                TIBCO.Rendezvous.Environment.Open();
                //Service,network,daemon should be AMA
                netTtransport = new NetTransport(service, network, daemon);
                queue = new TIBCO.Rendezvous.Queue();
                dispatcher = new Dispatcher(queue);
                //listen subject should be AMA
                listener = new Listener(queue, netTtransport, listenSubject, null);
                listener.MessageReceived += Listener_MessageReceived;
                this.btn_Connect.Text = "DisConnect";
                //isRvConnected = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Listener_MessageReceived(object listener, MessageReceivedEventArgs messageReceivedEventArgs)
        {
            try
            {
                if (messageReceivedEventArgs == null) return;
                string message = string.Empty;
                try
                {
                    message = messageReceivedEventArgs.Message.GetField("DATA").Value.ToString();
                }
                catch
                {
                    message = messageReceivedEventArgs.Message.GetXmlAsString("DATA");
                }
                //每次有新的数据进来，先存到总的Table里面
                if (!string.IsNullOrEmpty(message))
                {
                    var list = new List<string>();
                    list.Add(message.Trim(new char[] { '\r', '\n' }));
                    this.ResetLogList(list);
                }
                lock (lockObject)
                {
                    if (!this.InvokeRequired)
                    {
                        this.btn_Search_Click(null, null);
                        return;
                    }
                    this.BeginInvoke(new Action(() => { this.btn_Search_Click(null, null); }));
                }
                //如何判断当前的数据需要做筛选？
                //如果是正在Monitor那么就需要做到时时刷新，如果没有，那么只需要添加数据就好
                //if (isMonitoring)
                //{
                //    if (!string.IsNullOrEmpty(SetFilter())) { }
                //    bool isMatchKey = true;
                //    if (!string.IsNullOrEmpty(txt_KeyWord.Text) && !message.Contains(txt_KeyWord.Text)) isMatchKey = false;
                //    if (!string.IsNullOrEmpty(txtEqpId.Text) && !message.Contains(txtEqpId.Text)) isMatchKey = false;
                //    if (!string.IsNullOrEmpty(txtLotId.Text) && !message.Contains(txtLotId.Text)) isMatchKey = false;
                //    if (!string.IsNullOrEmpty(txtCarrierId.Text) && !message.Contains(txtCarrierId.Text)) isMatchKey = false;
                //    if (!string.IsNullOrEmpty(txtRuleName.Text) && !message.Contains(txtRuleName.Text)) isMatchKey = false;
                //    if (isMatchKey)
                //    {
                //        lock (lockObject)
                //        {
                //            if (this.InvokeRequired)
                //            {
                //                this.BeginInvoke(new Action(() =>
                //                {
                //                    this.btn_Search_Click(null, null);
                //                }));
                //            }
                //        }
                //    }
                //}
                //else
                //{
                //    lock (lockObject)
                //    {
                //        if (this.InvokeRequired)
                //        {
                //            this.BeginInvoke(new Action(() =>
                //            {
                //                this.grid_LogList.DataSource = SortLogInfo(logInfoList);
                //            }));
                //        }
                //    }

                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

        #region Private Method

        private DataTable SetLogList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("TimeStamp");
            dt.Columns.Add("MainJobExecId");
            dt.Columns.Add("LogLevel");
            dt.Columns.Add("ExecJobName");
            dt.Columns.Add("ExecJobStatus");
            dt.Columns.Add("TraceInfo");
            dt.Columns.Add("STN");
            dt.Columns.Add("PortId");
            dt.Columns.Add("LotId");
            dt.Columns.Add("CarrierId");
            dt.Columns.Add("Comments");
            dt.Columns.Add("SubJobName");
            dt.Columns.Add("SubJobExecId");
            dt.Columns.Add("CallingJobName");
            dt.Columns.Add("CallingJobExecId");
            dt.Columns.Add("MainJobName");
            dt.Columns.Add("ServerName");
            dt.Columns.Add("ServerHost");
            return dt;
        }

        private void Logging(string message)
        {
            //StringBuilder sb = new StringBuilder();
            message = DateTime.Now.ToString(dtFormat) + " | " + message;
            this.BeginInvoke(new Action(() =>
            {
              //if (!string.IsNullOrEmpty(txtExecActions.Text)) sb.AppendLine(txtExecActions.Text);
              //sb.AppendLine(message);
                txtExecActions.Text = string.IsNullOrEmpty(txtExecActions.Text)?
                message: txtExecActions.Text + System.Environment.NewLine + message;// sb.ToString();
            }));
        }

        private void ReadLogFile(string filePath)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this.Logging("Load File:" + filePath);
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        List<string> infoList = new List<string>();
                        string message = null;
                        string readLine = sr.ReadLine();
                        if (readLine != null) message = readLine;
                        while (!sr.EndOfStream)
                        {
                            readLine = sr.ReadLine();
                            if (readLine.StartsWith("INFO - "))
                            {
                                infoList.Add(message.Trim(new char[] { '\r', '\n' }));
                                message = readLine;
                            }
                            else if (!string.IsNullOrEmpty(readLine))
                            {
                                message += readLine;
                            }
                        }
                        this.ResetLogList(infoList);
                    }
                }                
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        //添加新的数据，并检查当前的数量是否大于设定的数量
        //如果大于，那么根据时间做排序，删除最早的数据，已经做过了时间排序
        private void ResetLogList(List<string> infoList)
        {
            #region Add Log Info
            foreach (string tmpInfo in infoList)
            {
                DataRow row = LogList.NewRow();

                string[] infos = tmpInfo.Split('^');

                if (infos.Length > 0)
                {
                    Match time = Regex.Match(infos[0], @"\d{2}/\d{2}/\d{4} \d{2}:\d{2}:\d{2}");
                    DateTime result = DateTime.Now;
                    if (time.Success)
                    {
                        result = DateTime.ParseExact(time.Value, "dd/MM/yyyy HH:mm:ss", culture);
                    }
                    row["TimeStamp"] = result.ToString(dtFormat);
                }

                string jobStatus = ProcessString(infos, "JobStatus");
                if (!string.IsNullOrEmpty(jobStatus))
                {
                    var tmp = jobStatus.Split('*');
                    if (tmp.Length >= 2)
                    {
                        row["ExecJobName"] = tmp[0];
                        row["ExecJobStatus"] = tmp[1];
                    }
                    else
                    {
                        Logging(jobStatus);
                    }
                }

                string subJobInfo = ProcessString(infos, "SubJob");
                if (!string.IsNullOrEmpty(subJobInfo))
                {
                    var tmp = subJobInfo.Split('|');
                    if (tmp.Length >= 2)
                    {
                        row["SubJobName"] = tmp[0];
                        row["SubJobExecId"] = tmp[1];
                    }
                    else
                    {
                        Logging(subJobInfo);
                    }
                }
                string callingJobInfo = ProcessString(infos, "CallingJob");
                if (!string.IsNullOrEmpty(callingJobInfo))
                {
                    var tmp = callingJobInfo.Split('|');
                    if (tmp.Length >= 2)
                    {
                        row["CallingJobName"] = tmp[0];
                        row["CallingJobExecId"] = tmp[1];
                    }
                    else
                    {
                        Logging(callingJobInfo);
                    }
                }
                string mainJobInfo = ProcessString(infos, "MainJob");
                if (!string.IsNullOrEmpty(mainJobInfo))
                {
                    var tmp = mainJobInfo.Split('|');
                    if (tmp.Length >= 2)
                    {
                        row["MainJobName"] = tmp[0];
                        row["MainJobExecId"] = tmp[1];
                    }
                    else
                    {
                        Logging(mainJobInfo);
                    }
                }

                row["TraceInfo"] = ProcessString(infos, "TraceInfo");
                row["LogLevel"] = ProcessString(infos, "LogLevel");
                row["STN"] = ProcessString(infos, "STN");
                row["PortId"] = ProcessString(infos, "PORT");
                row["CarrierId"] = ProcessString(infos, "CARRIER");
                row["LotId"] = ProcessString(infos, "LOT");
                row["Comments"] = ProcessString(infos, "Comments");
                row["ServerName"] = ProcessString(infos, "ServerName");
                row["ServerHost"] = ProcessString(infos, "ServerHost");

                lock (lockOfLogList) LogList.Rows.Add(row);
            }
            #endregion

            if (LogList.Rows.Count >= maxCount)
            {
                lock (lockOfLogList)
                {
                    LogList = LogList.AsEnumerable().OrderBy(
                        p => p["TimeStamp"].ToString()).ThenBy(
                        p => p["MainJobExecId"].ToString()).ThenBy(
                        p => p["ExecJobName"].ToString()).CopyToDataTable();

                    while (LogList.Rows.Count >= maxCount)
                    {
                        LogList.Rows.RemoveAt(0);
                    }
                }
            }


        }

        private string ProcessString(string[] infos, string infoName)
        {
            var tmpList = infos.Where(p => p.StartsWith(infoName)).ToList();
            if (tmpList.Count > 0)
            {
                Match match = Regex.Match(tmpList[0], @"=[\s\S]+");
                if (match.Success)
                {
                    return match.Value.Substring(1);
                }
            }
            return string.Empty;
        }

        private string FormatMessage(string input)
        {
            if (!input.StartsWith("<?xml version=")) return input;
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(input);
            StringWriter stringWriter = new StringWriter();
            using (XmlTextWriter writer = new XmlTextWriter(stringWriter))
            {
                writer.Indentation = 3;
                writer.Formatting = System.Xml.Formatting.Indented;
                xmlDocument.WriteContentTo(writer);
                writer.Close();
            }
            return stringWriter.ToString();
        }

        private string SetFilter()
        {
            string filter = string.Empty;
            if (!string.IsNullOrEmpty(txtEqpId.Text))
            {
                filter = SetFilterString(filter, string.Format("STN='{0}'", txtEqpId.Text));
            }
            if (!string.IsNullOrEmpty(txtPortId.Text))
            {
                filter = SetFilterString(filter, string.Format("PortId='{0}'", txtPortId.Text));
            }
            if (!string.IsNullOrEmpty(txtLotId.Text))
            {
                filter = SetFilterString(filter, string.Format("LotId='{0}'", txtLotId.Text));
            }
            if (!string.IsNullOrEmpty(txtCarrierId.Text))
            {
                filter = SetFilterString(filter, string.Format("CarrierId='{0}'", txtCarrierId.Text));
            }
            if (!string.IsNullOrEmpty(txtRuleName.Text))
            {
                filter = SetFilterString(filter, string.Format("ExecJobName='{0}'", txtRuleName.Text));
            }
            if (!string.IsNullOrEmpty(txt_MainJobExeId.Text))
            {
                filter = SetFilterString(filter, string.Format("MainJobExecId='{0}'", txt_MainJobExeId.Text));
            }
            if (!string.IsNullOrEmpty(txt_KeyWord.Text))
            {
                filter = SetFilterString(filter, string.Format("TraceInfo like '%{0}%'", txt_KeyWord.Text));
            }
            return filter;
        }

        private string SetFilterString(string currentFilter, string addFilter)
        {
            currentFilter = string.IsNullOrEmpty(currentFilter) ? addFilter : currentFilter + " and " + addFilter;
            return currentFilter;
        }

        //private DataTable SortLogInfo(DataTable dt)
        //{
        //    if (dt.Rows.Count > 0)
        //    {
        //        //var selected = dt.AsEnumerable().OrderByDescending(p => p["TimeStamp"].ToString()).Take(maxCount);
        //        var sorted = dt.AsEnumerable().OrderBy(p => p["TimeStamp"].ToString()).ThenBy(p => p["MainJobExecId"].ToString()).ThenBy(p => p["ExecJobName"].ToString());
        //        dt = sorted.CopyToDataTable();
        //    }
        //    return dt;
        //}

        private void BackupLog()
        {
            if (string.IsNullOrEmpty(backupLogPath)) return;
            if (!Directory.Exists(backupLogPath))
            {
                Directory.CreateDirectory(backupLogPath);
            }
            DirectoryInfo directoryInfo = new DirectoryInfo(localLogPath);
            FileInfo[] files = directoryInfo.GetFiles();
            foreach (FileInfo fileInfo in files)
            {
                string target = backupLogPath + fileInfo.LastWriteTime.ToString("yyyyMMddHHmmss");
                File.Move(fileInfo.FullName, target + "_" + fileInfo.Name);
            }
        }

        //TODO:Read Log with multi thread
        private void ReadLog()
        {
            string[] selectedFiles = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = true;
            dialog.InitialDirectory = @localLogPath;
            if (dialog.ShowDialog() != DialogResult.OK) return;
            selectedFiles = dialog.FileNames;
            if (selectedFiles == null || selectedFiles.Length <= 0) return;

            TaskFactory factory = new TaskFactory();
            List<Task> taskList = new List<Task>();
            for (int i = 0; i < selectedFiles.Length; i++)
            {
                string fileName = selectedFiles[i];
                var task = Task.Factory.StartNew(() =>
                {
                    ReadLogFile(fileName);
                });
                taskList.Add(task);
            }
            Task.Factory.ContinueWhenAll(
                taskList.ToArray(),
                input =>
                {
                    Logging("Read Complete");
                    var tmp = LogList.AsEnumerable().OrderBy(p => p["MainJobExecId"]).ThenBy(p => p["TimeStamp"]).ThenBy(p => p["ExecJobName"]);
                    if (tmp.Count() > 0) LogList = tmp.CopyToDataTable();
                    grid_LogList.DataSource = LogList;
                },
                System.Threading.CancellationToken.None);
        }

        private void StopConnecting()
        {
            try
            {
                if (dispatcher != null)
                {
                    dispatcher.Destroy();
                }
                if (queue != null)
                {
                    queue.Destroy();
                }
                if (netTtransport != null)
                {
                    netTtransport.Destroy();
                }
                if (listener != null)
                {
                    listener.Destroy();
                }
                TIBCO.Rendezvous.Environment.Close();
            }
            catch (Exception ex)
            {
                Logging(service + " Stop Connect Error:" + ex.Message);
            }
        }


        #endregion

    }
}
