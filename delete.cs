using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_manager
{
    public partial class delete : UserControl
    {
        public delete()
        {
            InitializeComponent();
            bunifuImageButton1.Visible = false;
        }
        string role, field;
        public delete(string R,string F)
        {
            this.role = R;
            this.field = F;
        }


        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (Ddgv.Rows != null)
            {
                DialogResult result = MessageBox.Show("are you sure you want to remove this data?", "delete user", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {

                    int userid = int.Parse(delID.Text);
                    DBLayer dB = new DBLayer();
                    dB.deleterow(userid);
                    MessageBox.Show("user data deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("data is empty");
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {

            DBLayer db = new DBLayer();
            String query;
            query = "exec spSelectAllEmployeeforAdmin " + int.Parse(delID.Text);
            DataTable dt = db.getRecords(query);
            Ddgv.DataSource = dt;
            if (Ddgv != null)
            {
                bunifuImageButton1.Visible = true;
            }
        }

        private void Ddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 1 && e.ColumnIndex > 0)
            {
              
                if (Ddgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    Ddgv.CurrentRow.Selected = true;
                  
                    delID.Text = Ddgv.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                    
                }
            }
        }
    }
}
