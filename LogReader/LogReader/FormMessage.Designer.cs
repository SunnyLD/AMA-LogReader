namespace LogReader
{
    partial class FormMessage
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
            this.txt_Message = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txt_Message
            // 
            this.txt_Message.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Message.Location = new System.Drawing.Point(0, 0);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(977, 576);
            this.txt_Message.TabIndex = 0;
            this.txt_Message.Text = "";
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 576);
            this.Controls.Add(this.txt_Message);
            this.Name = "FormMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Info";
            this.Load += new System.EventHandler(this.FormMessage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Message;
    }
}