using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogReader
{
    public partial class FormMessage : Form
    {
        public bool AutoMatchFlag { get; set; }
        public string SendMessage { get; set; }
        public string ReplyMessage { get; set; }
        public FormMessage()
        {
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            if (AutoMatchFlag)
            {
                this.txt_Message.SelectionColor = Color.Red;
                this.txt_Message.AppendText("SEND:");
                this.txt_Message.AppendText(Environment.NewLine);
                this.txt_Message.SelectionColor = txt_Message.ForeColor;
                this.txt_Message.AppendText(SendMessage);
                this.txt_Message.AppendText(Environment.NewLine);
                this.txt_Message.SelectionColor = Color.Red;
                this.txt_Message.AppendText("REPLY:");
                this.txt_Message.AppendText(Environment.NewLine);
                this.txt_Message.SelectionColor = txt_Message.ForeColor;
                this.txt_Message.AppendText(ReplyMessage);
            }
            else
            {
                this.txt_Message.Text = SendMessage;
            }
        }
    }
}
