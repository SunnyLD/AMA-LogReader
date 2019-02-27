namespace LogReader
{
    partial class FormMonitor
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
            this.tpl_Main = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Filter = new System.Windows.Forms.Label();
            this.txt_Filter = new System.Windows.Forms.TextBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.grp_List = new System.Windows.Forms.GroupBox();
            this.gird_LogList = new System.Windows.Forms.DataGridView();
            this.ckb_AutoMatch = new System.Windows.Forms.CheckBox();
            this.tpl_Main.SuspendLayout();
            this.grp_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gird_LogList)).BeginInit();
            this.SuspendLayout();
            // 
            // tpl_Main
            // 
            this.tpl_Main.ColumnCount = 3;
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tpl_Main.Controls.Add(this.ckb_AutoMatch, 2, 0);
            this.tpl_Main.Controls.Add(this.lbl_Filter, 0, 0);
            this.tpl_Main.Controls.Add(this.txt_Filter, 1, 0);
            this.tpl_Main.Controls.Add(this.btn_Close, 2, 2);
            this.tpl_Main.Controls.Add(this.grp_List, 0, 1);
            this.tpl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tpl_Main.Location = new System.Drawing.Point(0, 0);
            this.tpl_Main.Name = "tpl_Main";
            this.tpl_Main.RowCount = 3;
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tpl_Main.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tpl_Main.Size = new System.Drawing.Size(965, 529);
            this.tpl_Main.TabIndex = 0;
            // 
            // lbl_Filter
            // 
            this.lbl_Filter.AutoSize = true;
            this.lbl_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Filter.Location = new System.Drawing.Point(3, 0);
            this.lbl_Filter.Name = "lbl_Filter";
            this.lbl_Filter.Size = new System.Drawing.Size(41, 27);
            this.lbl_Filter.TabIndex = 0;
            this.lbl_Filter.Text = "Filter";
            // 
            // txt_Filter
            // 
            this.txt_Filter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Filter.Location = new System.Drawing.Point(50, 3);
            this.txt_Filter.Name = "txt_Filter";
            this.txt_Filter.ReadOnly = true;
            this.txt_Filter.Size = new System.Drawing.Size(769, 21);
            this.txt_Filter.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Location = new System.Drawing.Point(887, 503);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            // 
            // grp_List
            // 
            this.tpl_Main.SetColumnSpan(this.grp_List, 3);
            this.grp_List.Controls.Add(this.gird_LogList);
            this.grp_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_List.Location = new System.Drawing.Point(3, 30);
            this.grp_List.Name = "grp_List";
            this.grp_List.Size = new System.Drawing.Size(959, 467);
            this.grp_List.TabIndex = 3;
            this.grp_List.TabStop = false;
            this.grp_List.Text = "Log List";
            // 
            // gird_LogList
            // 
            this.gird_LogList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gird_LogList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gird_LogList.Location = new System.Drawing.Point(3, 17);
            this.gird_LogList.Name = "gird_LogList";
            this.gird_LogList.RowTemplate.Height = 23;
            this.gird_LogList.Size = new System.Drawing.Size(953, 447);
            this.gird_LogList.TabIndex = 4;
            this.gird_LogList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gird_LogList_CellDoubleClick);
            // 
            // ckb_AutoMatch
            // 
            this.ckb_AutoMatch.AutoSize = true;
            this.ckb_AutoMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb_AutoMatch.Location = new System.Drawing.Point(824, 2);
            this.ckb_AutoMatch.Margin = new System.Windows.Forms.Padding(2);
            this.ckb_AutoMatch.Name = "ckb_AutoMatch";
            this.ckb_AutoMatch.Size = new System.Drawing.Size(139, 21);
            this.ckb_AutoMatch.TabIndex = 28;
            this.ckb_AutoMatch.Text = "Match Message";
            this.ckb_AutoMatch.UseVisualStyleBackColor = true;
            // 
            // FormMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 529);
            this.Controls.Add(this.tpl_Main);
            this.Name = "FormMonitor";
            this.Text = "FormMonitor";
            this.Load += new System.EventHandler(this.FormMonitor_Load);
            this.tpl_Main.ResumeLayout(false);
            this.tpl_Main.PerformLayout();
            this.grp_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gird_LogList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tpl_Main;
        private System.Windows.Forms.Label lbl_Filter;
        private System.Windows.Forms.TextBox txt_Filter;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox grp_List;
        private System.Windows.Forms.DataGridView gird_LogList;
        private System.Windows.Forms.CheckBox ckb_AutoMatch;
    }
}