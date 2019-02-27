namespace LogReader
{
    partial class FormConfiguration
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
        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // FormConfiguration
        //    // 
        //    this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        //    this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    this.ClientSize = new System.Drawing.Size(802, 514);
        //    this.Name = "FormConfiguration";
        //    this.Text = "FormConfiguration";
        //    this.ResumeLayout(false);

        //}


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Environment = new System.Windows.Forms.Label();
            this.cmb_Environment = new System.Windows.Forms.ComboBox();
            this.lbl_FileName = new System.Windows.Forms.Label();
            this.cmb_FileList = new System.Windows.Forms.ComboBox();
            this.btn_Open = new System.Windows.Forms.Button();
            this.grp_Configuration = new System.Windows.Forms.GroupBox();
            this.grd_Configuration = new System.Windows.Forms.DataGridView();
            this.lbl_SearchKey = new System.Windows.Forms.Label();
            this.cmb_SearchKey = new System.Windows.Forms.ComboBox();
            this.lbl_SearchValue = new System.Windows.Forms.Label();
            this.txt_SearchValue = new System.Windows.Forms.TextBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.tpl_Main.SuspendLayout();
            this.grp_Configuration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Configuration)).BeginInit();
            this.SuspendLayout();
            // 
            // tpl_Main
            // 
            this.tpl_Main.ColumnCount = 5;
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_Main.Controls.Add(this.lbl_Environment, 0, 0);
            this.tpl_Main.Controls.Add(this.cmb_Environment, 0, 1);
            this.tpl_Main.Controls.Add(this.lbl_FileName, 1, 0);
            this.tpl_Main.Controls.Add(this.cmb_FileList, 1, 1);
            this.tpl_Main.Controls.Add(this.btn_Open, 2, 1);
            this.tpl_Main.Controls.Add(this.grp_Configuration, 0, 4);
            this.tpl_Main.Controls.Add(this.lbl_SearchKey, 0, 2);
            this.tpl_Main.Controls.Add(this.cmb_SearchKey, 0, 3);
            this.tpl_Main.Controls.Add(this.lbl_SearchValue, 1, 2);
            this.tpl_Main.Controls.Add(this.txt_SearchValue, 1, 3);
            this.tpl_Main.Controls.Add(this.btn_Search, 2, 3);
            this.tpl_Main.Controls.Add(this.btn_Export, 3, 3);
            this.tpl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_Main.Location = new System.Drawing.Point(0, 0);
            this.tpl_Main.Name = "tpl_Main";
            this.tpl_Main.RowCount = 6;
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.Size = new System.Drawing.Size(1467, 828);
            this.tpl_Main.TabIndex = 0;
            // 
            // lbl_Environment
            // 
            this.lbl_Environment.AutoSize = true;
            this.lbl_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Environment.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Environment.Location = new System.Drawing.Point(3, 12);
            this.lbl_Environment.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lbl_Environment.Name = "lbl_Environment";
            this.lbl_Environment.Size = new System.Drawing.Size(296, 16);
            this.lbl_Environment.TabIndex = 0;
            this.lbl_Environment.Text = "Environment";
            // 
            // cmb_Environment
            // 
            this.cmb_Environment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Environment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Environment.FormattingEnabled = true;
            this.cmb_Environment.Location = new System.Drawing.Point(3, 31);
            this.cmb_Environment.Name = "cmb_Environment";
            this.cmb_Environment.Size = new System.Drawing.Size(296, 21);
            this.cmb_Environment.TabIndex = 1;
            this.cmb_Environment.SelectedIndexChanged += new System.EventHandler(this.cmb_Environment_SelectedIndexChanged);
            // 
            // lbl_FileName
            // 
            this.lbl_FileName.AutoSize = true;
            this.lbl_FileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_FileName.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_FileName.Location = new System.Drawing.Point(305, 12);
            this.lbl_FileName.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.lbl_FileName.Name = "lbl_FileName";
            this.lbl_FileName.Size = new System.Drawing.Size(388, 16);
            this.lbl_FileName.TabIndex = 2;
            this.lbl_FileName.Text = "File Name";
            // 
            // cmb_FileList
            // 
            this.cmb_FileList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_FileList.FormattingEnabled = true;
            this.cmb_FileList.Location = new System.Drawing.Point(305, 31);
            this.cmb_FileList.Name = "cmb_FileList";
            this.cmb_FileList.Size = new System.Drawing.Size(388, 21);
            this.cmb_FileList.TabIndex = 3;
            // 
            // btn_Open
            // 
            this.btn_Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Open.Location = new System.Drawing.Point(699, 31);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(92, 27);
            this.btn_Open.TabIndex = 4;
            this.btn_Open.Text = "Open";
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // grp_Configuration
            // 
            this.tpl_Main.SetColumnSpan(this.grp_Configuration, 5);
            this.grp_Configuration.Controls.Add(this.grd_Configuration);
            this.grp_Configuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Configuration.Location = new System.Drawing.Point(3, 113);
            this.grp_Configuration.Name = "grp_Configuration";
            this.grp_Configuration.Size = new System.Drawing.Size(1461, 712);
            this.grp_Configuration.TabIndex = 6;
            this.grp_Configuration.TabStop = false;
            this.grp_Configuration.Text = "Configuration List";
            // 
            // grd_Configuration
            // 
            this.grd_Configuration.AllowUserToResizeRows = false;
            this.grd_Configuration.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grd_Configuration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Configuration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_Configuration.Location = new System.Drawing.Point(3, 16);
            this.grd_Configuration.Name = "grd_Configuration";
            this.grd_Configuration.RowTemplate.Height = 28;
            this.grd_Configuration.Size = new System.Drawing.Size(1455, 693);
            this.grd_Configuration.TabIndex = 0;
            // 
            // lbl_SearchKey
            // 
            this.lbl_SearchKey.AutoSize = true;
            this.lbl_SearchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SearchKey.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_SearchKey.Location = new System.Drawing.Point(3, 61);
            this.lbl_SearchKey.Name = "lbl_SearchKey";
            this.lbl_SearchKey.Size = new System.Drawing.Size(296, 16);
            this.lbl_SearchKey.TabIndex = 8;
            this.lbl_SearchKey.Text = "Search Key";
            // 
            // cmb_SearchKey
            // 
            this.cmb_SearchKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_SearchKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SearchKey.FormattingEnabled = true;
            this.cmb_SearchKey.Location = new System.Drawing.Point(3, 80);
            this.cmb_SearchKey.Name = "cmb_SearchKey";
            this.cmb_SearchKey.Size = new System.Drawing.Size(296, 21);
            this.cmb_SearchKey.TabIndex = 9;
            // 
            // lbl_SearchValue
            // 
            this.lbl_SearchValue.AutoSize = true;
            this.lbl_SearchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_SearchValue.Font = new System.Drawing.Font("Monotype Corsiva", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_SearchValue.Location = new System.Drawing.Point(305, 61);
            this.lbl_SearchValue.Name = "lbl_SearchValue";
            this.lbl_SearchValue.Size = new System.Drawing.Size(388, 16);
            this.lbl_SearchValue.TabIndex = 10;
            this.lbl_SearchValue.Text = "Search Value";
            // 
            // txt_SearchValue
            // 
            this.txt_SearchValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_SearchValue.Location = new System.Drawing.Point(305, 80);
            this.txt_SearchValue.Name = "txt_SearchValue";
            this.txt_SearchValue.Size = new System.Drawing.Size(388, 20);
            this.txt_SearchValue.TabIndex = 11;
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(699, 80);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(92, 27);
            this.btn_Search.TabIndex = 5;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Enabled = false;
            this.btn_Export.Location = new System.Drawing.Point(797, 80);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(91, 26);
            this.btn_Export.TabIndex = 12;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // FormConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 828);
            this.Controls.Add(this.tpl_Main);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Name = "FormConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tpl_Main.ResumeLayout(false);
            this.tpl_Main.PerformLayout();
            this.grp_Configuration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Configuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpl_Main;
        private System.Windows.Forms.Label lbl_Environment;
        private System.Windows.Forms.ComboBox cmb_Environment;
        private System.Windows.Forms.Label lbl_FileName;
        private System.Windows.Forms.ComboBox cmb_FileList;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.GroupBox grp_Configuration;
        private System.Windows.Forms.DataGridView grd_Configuration;
        private System.Windows.Forms.Label lbl_SearchKey;
        private System.Windows.Forms.ComboBox cmb_SearchKey;
        private System.Windows.Forms.Label lbl_SearchValue;
        private System.Windows.Forms.TextBox txt_SearchValue;
        private System.Windows.Forms.Button btn_Export;

        #endregion
    }
}