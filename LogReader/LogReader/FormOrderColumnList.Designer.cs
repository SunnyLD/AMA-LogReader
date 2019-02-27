namespace LogReader
{
    partial class FormOrderColumnList
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
            this.grid_OrderColumns = new System.Windows.Forms.DataGridView();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderColumns)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_OrderColumns
            // 
            this.grid_OrderColumns.AllowUserToAddRows = false;
            this.grid_OrderColumns.AllowUserToDeleteRows = false;
            this.grid_OrderColumns.AllowUserToResizeRows = false;
            this.grid_OrderColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.grid_OrderColumns, 2);
            this.grid_OrderColumns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_OrderColumns.Location = new System.Drawing.Point(3, 3);
            this.grid_OrderColumns.Name = "grid_OrderColumns";
            this.grid_OrderColumns.RowTemplate.Height = 28;
            this.grid_OrderColumns.Size = new System.Drawing.Size(449, 707);
            this.grid_OrderColumns.TabIndex = 0;
            this.grid_OrderColumns.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_OrderColumns_CellClick);
            this.grid_OrderColumns.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.grid_OrderColumns_ColumnAdded);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Confirm.Location = new System.Drawing.Point(377, 716);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(75, 31);
            this.btn_Confirm.TabIndex = 1;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.grid_OrderColumns, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Confirm, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(455, 750);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FormOrderColumnList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 750);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormOrderColumnList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Column List";
            this.Load += new System.EventHandler(this.FormOrderSeq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_OrderColumns)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_OrderColumns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Confirm;
    }
}