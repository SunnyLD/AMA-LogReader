namespace LogReader
{
    partial class FormLogReader
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogReader));
            this.tpl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.grp_LogList = new System.Windows.Forms.GroupBox();
            this.grid_LogList = new System.Windows.Forms.DataGridView();
            this.txtExecActions = new System.Windows.Forms.RichTextBox();
            this.lblEqp = new System.Windows.Forms.Label();
            this.txtEqpId = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPortId = new System.Windows.Forms.TextBox();
            this.llbLot = new System.Windows.Forms.Label();
            this.txtLotId = new System.Windows.Forms.TextBox();
            this.lblCarrier = new System.Windows.Forms.Label();
            this.txtCarrierId = new System.Windows.Forms.TextBox();
            this.lblRuleName = new System.Windows.Forms.Label();
            this.txtRuleName = new System.Windows.Forms.TextBox();
            this.lbl_EndTime = new System.Windows.Forms.Label();
            this.dtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.lbl_StartTime = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.lblEnvironment = new System.Windows.Forms.Label();
            this.cmbEnvironment = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.item_Configuration = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblApplication = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.cbx_Backup = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.ckb_AutoMatch = new System.Windows.Forms.CheckBox();
            this.lblMainJobExeId = new System.Windows.Forms.Label();
            this.txt_MainJobExeId = new System.Windows.Forms.TextBox();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_KeyWord = new System.Windows.Forms.Label();
            this.txt_KeyWord = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tpl_Main.SuspendLayout();
            this.grp_LogList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_LogList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpl_Main
            // 
            this.tpl_Main.BackColor = System.Drawing.SystemColors.Control;
            this.tpl_Main.ColumnCount = 11;
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_Main.Controls.Add(this.grp_LogList, 0, 5);
            this.tpl_Main.Controls.Add(this.txtExecActions, 0, 6);
            this.tpl_Main.Controls.Add(this.lblEqp, 0, 3);
            this.tpl_Main.Controls.Add(this.txtEqpId, 0, 4);
            this.tpl_Main.Controls.Add(this.lblPort, 1, 3);
            this.tpl_Main.Controls.Add(this.txtPortId, 1, 4);
            this.tpl_Main.Controls.Add(this.llbLot, 2, 3);
            this.tpl_Main.Controls.Add(this.txtLotId, 2, 4);
            this.tpl_Main.Controls.Add(this.lblCarrier, 3, 3);
            this.tpl_Main.Controls.Add(this.txtCarrierId, 3, 4);
            this.tpl_Main.Controls.Add(this.lblRuleName, 4, 3);
            this.tpl_Main.Controls.Add(this.txtRuleName, 4, 4);
            this.tpl_Main.Controls.Add(this.lbl_EndTime, 2, 1);
            this.tpl_Main.Controls.Add(this.dtpEndTime, 2, 2);
            this.tpl_Main.Controls.Add(this.lbl_StartTime, 1, 1);
            this.tpl_Main.Controls.Add(this.dtpStartTime, 1, 2);
            this.tpl_Main.Controls.Add(this.lblEnvironment, 0, 1);
            this.tpl_Main.Controls.Add(this.cmbEnvironment, 0, 2);
            this.tpl_Main.Controls.Add(this.menuStrip1, 0, 0);
            this.tpl_Main.Controls.Add(this.statusStrip1, 0, 7);
            this.tpl_Main.Controls.Add(this.cbx_Backup, 3, 2);
            this.tpl_Main.Controls.Add(this.btnDownload, 5, 2);
            this.tpl_Main.Controls.Add(this.ckb_AutoMatch, 4, 2);
            this.tpl_Main.Controls.Add(this.lblMainJobExeId, 5, 3);
            this.tpl_Main.Controls.Add(this.txt_MainJobExeId, 5, 4);
            this.tpl_Main.Controls.Add(this.btn_Connect, 6, 2);
            this.tpl_Main.Controls.Add(this.btn_Export, 10, 4);
            this.tpl_Main.Controls.Add(this.btn_Clear, 9, 4);
            this.tpl_Main.Controls.Add(this.btnSearch, 8, 4);
            this.tpl_Main.Controls.Add(this.btn_Open, 7, 4);
            this.tpl_Main.Controls.Add(this.lbl_KeyWord, 6, 3);
            this.tpl_Main.Controls.Add(this.txt_KeyWord, 6, 4);
            this.tpl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_Main.Location = new System.Drawing.Point(0, 0);
            this.tpl_Main.Name = "tpl_Main";
            this.tpl_Main.RowCount = 8;
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tpl_Main.Size = new System.Drawing.Size(2564, 1060);
            this.tpl_Main.TabIndex = 0;
            // 
            // grp_LogList
            // 
            this.tpl_Main.SetColumnSpan(this.grp_LogList, 11);
            this.grp_LogList.Controls.Add(this.grid_LogList);
            this.grp_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_LogList.Location = new System.Drawing.Point(3, 186);
            this.grp_LogList.Name = "grp_LogList";
            this.grp_LogList.Size = new System.Drawing.Size(2558, 666);
            this.grp_LogList.TabIndex = 1;
            this.grp_LogList.TabStop = false;
            this.grp_LogList.Text = "Log List";
            // 
            // grid_LogList
            // 
            this.grid_LogList.BackgroundColor = System.Drawing.Color.White;
            this.grid_LogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_LogList.Location = new System.Drawing.Point(3, 22);
            this.grid_LogList.Name = "grid_LogList";
            this.grid_LogList.ReadOnly = true;
            this.grid_LogList.RowHeadersWidth = 10;
            this.grid_LogList.RowTemplate.Height = 28;
            this.grid_LogList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid_LogList.Size = new System.Drawing.Size(2552, 641);
            this.grid_LogList.TabIndex = 0;
            this.grid_LogList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_LogList_CellDoubleClick);
            this.grid_LogList.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_LogList_ColumnAdded);
            // 
            // txtExecActions
            // 
            this.txtExecActions.BackColor = System.Drawing.Color.White;
            this.tpl_Main.SetColumnSpan(this.txtExecActions, 11);
            this.txtExecActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtExecActions.Location = new System.Drawing.Point(3, 858);
            this.txtExecActions.Name = "txtExecActions";
            this.txtExecActions.Size = new System.Drawing.Size(2558, 162);
            this.txtExecActions.TabIndex = 14;
            this.txtExecActions.Text = "";
            // 
            // lblEqp
            // 
            this.lblEqp.AutoSize = true;
            this.lblEqp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEqp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqp.Location = new System.Drawing.Point(3, 108);
            this.lblEqp.Name = "lblEqp";
            this.lblEqp.Size = new System.Drawing.Size(278, 22);
            this.lblEqp.TabIndex = 19;
            this.lblEqp.Text = "Eqp";
            // 
            // txtEqpId
            // 
            this.txtEqpId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtEqpId.Location = new System.Drawing.Point(3, 133);
            this.txtEqpId.Name = "txtEqpId";
            this.txtEqpId.Size = new System.Drawing.Size(278, 26);
            this.txtEqpId.TabIndex = 20;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(287, 108);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(271, 22);
            this.lblPort.TabIndex = 21;
            this.lblPort.Text = "Port";
            // 
            // txtPortId
            // 
            this.txtPortId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPortId.Location = new System.Drawing.Point(287, 133);
            this.txtPortId.Name = "txtPortId";
            this.txtPortId.Size = new System.Drawing.Size(271, 26);
            this.txtPortId.TabIndex = 22;
            // 
            // llbLot
            // 
            this.llbLot.AutoSize = true;
            this.llbLot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLot.Location = new System.Drawing.Point(564, 108);
            this.llbLot.Name = "llbLot";
            this.llbLot.Size = new System.Drawing.Size(258, 22);
            this.llbLot.TabIndex = 23;
            this.llbLot.Text = "Lot";
            // 
            // txtLotId
            // 
            this.txtLotId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLotId.Location = new System.Drawing.Point(564, 133);
            this.txtLotId.Name = "txtLotId";
            this.txtLotId.Size = new System.Drawing.Size(258, 26);
            this.txtLotId.TabIndex = 24;
            // 
            // lblCarrier
            // 
            this.lblCarrier.AutoSize = true;
            this.lblCarrier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCarrier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarrier.Location = new System.Drawing.Point(828, 108);
            this.lblCarrier.Name = "lblCarrier";
            this.lblCarrier.Size = new System.Drawing.Size(268, 22);
            this.lblCarrier.TabIndex = 25;
            this.lblCarrier.Text = "Carrier";
            // 
            // txtCarrierId
            // 
            this.txtCarrierId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCarrierId.Location = new System.Drawing.Point(828, 133);
            this.txtCarrierId.Name = "txtCarrierId";
            this.txtCarrierId.Size = new System.Drawing.Size(268, 26);
            this.txtCarrierId.TabIndex = 26;
            // 
            // lblRuleName
            // 
            this.lblRuleName.AutoSize = true;
            this.lblRuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuleName.Location = new System.Drawing.Point(1102, 108);
            this.lblRuleName.Name = "lblRuleName";
            this.lblRuleName.Size = new System.Drawing.Size(284, 22);
            this.lblRuleName.TabIndex = 28;
            this.lblRuleName.Text = "Rule Name";
            // 
            // txtRuleName
            // 
            this.txtRuleName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRuleName.Location = new System.Drawing.Point(1102, 133);
            this.txtRuleName.Name = "txtRuleName";
            this.txtRuleName.Size = new System.Drawing.Size(284, 26);
            this.txtRuleName.TabIndex = 29;
            // 
            // lbl_EndTime
            // 
            this.lbl_EndTime.AutoSize = true;
            this.lbl_EndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_EndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EndTime.Location = new System.Drawing.Point(564, 42);
            this.lbl_EndTime.Name = "lbl_EndTime";
            this.lbl_EndTime.Size = new System.Drawing.Size(258, 22);
            this.lbl_EndTime.TabIndex = 6;
            this.lbl_EndTime.Text = "End Time";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpEndTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndTime.Location = new System.Drawing.Point(564, 67);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.Size = new System.Drawing.Size(258, 26);
            this.dtpEndTime.TabIndex = 7;
            // 
            // lbl_StartTime
            // 
            this.lbl_StartTime.AutoSize = true;
            this.lbl_StartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_StartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StartTime.Location = new System.Drawing.Point(287, 42);
            this.lbl_StartTime.Name = "lbl_StartTime";
            this.lbl_StartTime.Size = new System.Drawing.Size(271, 22);
            this.lbl_StartTime.TabIndex = 5;
            this.lbl_StartTime.Text = "Start Time";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dtpStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(287, 67);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(271, 26);
            this.dtpStartTime.TabIndex = 4;
            // 
            // lblEnvironment
            // 
            this.lblEnvironment.AutoSize = true;
            this.lblEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnvironment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnvironment.Location = new System.Drawing.Point(3, 42);
            this.lblEnvironment.Name = "lblEnvironment";
            this.lblEnvironment.Size = new System.Drawing.Size(278, 22);
            this.lblEnvironment.TabIndex = 30;
            this.lblEnvironment.Text = "Environment";
            // 
            // cmbEnvironment
            // 
            this.cmbEnvironment.BackColor = System.Drawing.Color.White;
            this.cmbEnvironment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEnvironment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEnvironment.FormattingEnabled = true;
            this.cmbEnvironment.Location = new System.Drawing.Point(3, 67);
            this.cmbEnvironment.Name = "cmbEnvironment";
            this.cmbEnvironment.Size = new System.Drawing.Size(278, 28);
            this.cmbEnvironment.TabIndex = 31;
            this.cmbEnvironment.SelectedIndexChanged += new System.EventHandler(this.cmbEnvironment_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_Configuration});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(284, 35);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // item_Configuration
            // 
            this.item_Configuration.Name = "item_Configuration";
            this.item_Configuration.Size = new System.Drawing.Size(133, 29);
            this.item_Configuration.Text = "Configuration";
            this.item_Configuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.item_Configuration.Click += new System.EventHandler(this.item_Configuration_Click);
            // 
            // statusStrip1
            // 
            this.tpl_Main.SetColumnSpan(this.statusStrip1, 11);
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblApplication,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1023);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 14, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(2564, 37);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblApplication
            // 
            this.lblApplication.Name = "lblApplication";
            this.lblApplication.Size = new System.Drawing.Size(175, 32);
            this.lblApplication.Text = "Reader Application | ";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(179, 32);
            this.lblTime.Text = "2018-06-08 00:00:00";
            // 
            // cbx_Backup
            // 
            this.cbx_Backup.AutoSize = true;
            this.cbx_Backup.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbx_Backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_Backup.Location = new System.Drawing.Point(828, 67);
            this.cbx_Backup.Name = "cbx_Backup";
            this.cbx_Backup.Size = new System.Drawing.Size(180, 38);
            this.cbx_Backup.TabIndex = 33;
            this.cbx_Backup.Text = "Backup Log File";
            this.cbx_Backup.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.Control;
            this.btnDownload.Location = new System.Drawing.Point(1392, 67);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(279, 38);
            this.btnDownload.TabIndex = 18;
            this.btnDownload.Text = "Download File";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ckb_AutoMatch
            // 
            this.ckb_AutoMatch.AutoSize = true;
            this.ckb_AutoMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_AutoMatch.Location = new System.Drawing.Point(1102, 67);
            this.ckb_AutoMatch.Name = "ckb_AutoMatch";
            this.ckb_AutoMatch.Size = new System.Drawing.Size(191, 29);
            this.ckb_AutoMatch.TabIndex = 27;
            this.ckb_AutoMatch.Text = "Match Message";
            this.ckb_AutoMatch.UseVisualStyleBackColor = true;
            // 
            // lblMainJobExeId
            // 
            this.lblMainJobExeId.AutoSize = true;
            this.lblMainJobExeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblMainJobExeId.Location = new System.Drawing.Point(1393, 108);
            this.lblMainJobExeId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainJobExeId.Name = "lblMainJobExeId";
            this.lblMainJobExeId.Size = new System.Drawing.Size(144, 22);
            this.lblMainJobExeId.TabIndex = 35;
            this.lblMainJobExeId.Text = "MainJobExecId";
            // 
            // txt_MainJobExeId
            // 
            this.txt_MainJobExeId.Location = new System.Drawing.Point(1393, 135);
            this.txt_MainJobExeId.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_MainJobExeId.Name = "txt_MainJobExeId";
            this.txt_MainJobExeId.Size = new System.Drawing.Size(276, 26);
            this.txt_MainJobExeId.TabIndex = 36;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(1677, 67);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(279, 38);
            this.btn_Connect.TabIndex = 38;
            this.btn_Connect.Text = "Connect RV";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Export.Location = new System.Drawing.Point(2284, 133);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(98, 47);
            this.btn_Export.TabIndex = 34;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(2174, 133);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(104, 38);
            this.btn_Clear.TabIndex = 16;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(2062, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 38);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Open
            // 
            this.btn_Open.Location = new System.Drawing.Point(1962, 133);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(94, 38);
            this.btn_Open.TabIndex = 0;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl_KeyWord
            // 
            this.lbl_KeyWord.AutoSize = true;
            this.lbl_KeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_KeyWord.Location = new System.Drawing.Point(1678, 108);
            this.lbl_KeyWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_KeyWord.Name = "lbl_KeyWord";
            this.lbl_KeyWord.Size = new System.Drawing.Size(97, 22);
            this.lbl_KeyWord.TabIndex = 39;
            this.lbl_KeyWord.Text = "Key Word";
            // 
            // txt_KeyWord
            // 
            this.txt_KeyWord.Location = new System.Drawing.Point(1678, 135);
            this.txt_KeyWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_KeyWord.Name = "txt_KeyWord";
            this.txt_KeyWord.Size = new System.Drawing.Size(276, 26);
            this.txt_KeyWord.TabIndex = 40;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormLogReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(2564, 1060);
            this.Controls.Add(this.tpl_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1594, 776);
            this.Name = "FormLogReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reader";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogReader_Load);
            this.tpl_Main.ResumeLayout(false);
            this.tpl_Main.PerformLayout();
            this.grp_LogList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_LogList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpl_Main;
        private System.Windows.Forms.GroupBox grp_LogList;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.DataGridView grid_LogList;
        private System.Windows.Forms.DateTimePicker dtpStartTime;
        private System.Windows.Forms.Label lbl_StartTime;
        private System.Windows.Forms.Label lbl_EndTime;
        private System.Windows.Forms.DateTimePicker dtpEndTime;
        private System.Windows.Forms.RichTextBox txtExecActions;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Label lblEqp;
        private System.Windows.Forms.TextBox txtEqpId;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPortId;
        private System.Windows.Forms.Label llbLot;
        private System.Windows.Forms.TextBox txtLotId;
        private System.Windows.Forms.Label lblCarrier;
        private System.Windows.Forms.TextBox txtCarrierId;
        private System.Windows.Forms.CheckBox ckb_AutoMatch;
        private System.Windows.Forms.Label lblRuleName;
        private System.Windows.Forms.TextBox txtRuleName;
        private System.Windows.Forms.Label lblEnvironment;
        private System.Windows.Forms.ComboBox cmbEnvironment;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblApplication;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox cbx_Backup;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label lblMainJobExeId;
        private System.Windows.Forms.TextBox txt_MainJobExeId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem item_Configuration;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Label lbl_KeyWord;
        private System.Windows.Forms.TextBox txt_KeyWord;
    }
}

