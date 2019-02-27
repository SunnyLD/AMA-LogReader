using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogReader
{
    public partial class FormMonitor : Form
    {
        public DataTable LogList { get; set; }
        public string RecieveMessage { get; set; }
        public string Filter { get; set; }

        public FormMonitor()
        {
            InitializeComponent();
        }

        private void FormMonitor_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Filter)) txt_Filter.Text = Filter;
            gird_LogList.DataSource = LogList;
        }

        private void gird_LogList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
