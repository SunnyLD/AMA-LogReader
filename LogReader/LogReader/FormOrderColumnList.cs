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
    public partial class FormOrderColumnList : Form
    {
        private List<string> orderList;
        public List<string> ColumnNames { get; set; }
        public List<string> OrderColumns
        {
            get
            {
                return orderList;
            }
        }

        public FormOrderColumnList()
        {
            InitializeComponent();
        }

        private void FormOrderSeq_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("CheckBoxColumn", typeof(bool));
            dt.Columns.Add("OrderColumnName", typeof(string));
            if (ColumnNames != null && ColumnNames.Count > 0)
            {
                foreach (var columnName in ColumnNames)
                {
                    DataRow row = dt.NewRow();
                    row["CheckBoxColumn"] = false;
                    row["OrderColumnName"] = columnName;
                    dt.Rows.Add(row);
                }
            }
            grid_OrderColumns.DataSource = dt;
        }

        private void grid_OrderColumns_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0) return;
            if (orderList == null) orderList = new List<string>();
            var selected = Convert.ToBoolean(grid_OrderColumns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            var columnName = grid_OrderColumns.Rows[e.RowIndex].Cells["OrderColumnName"].Value.ToString();
            if (selected)
            {
                if (orderList.Contains(columnName))
                {
                    orderList.Remove(columnName);
                }
                grid_OrderColumns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
            }
            else
            {
                orderList.Add(columnName);
                grid_OrderColumns.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
            }
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void grid_OrderColumns_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (!e.Column.Name.Equals("CheckBoxColumn")) e.Column.ReadOnly = true;
        }
    }
}
