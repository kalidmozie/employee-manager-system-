using System;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_manager
{
    public partial class view : UserControl
    {
        string field, role;

        public view(string r,string f)
        {
            InitializeComponent();
            this.role = r;
            this.field = f;
        }

        private void Dg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    if (dg.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {

                        dg.CurrentRow.Selected = true;
                        label7.Text = dg.Rows[e.RowIndex].Cells["id"].FormattedValue.ToString();
                        label8.Text = dg.Rows[e.RowIndex].Cells["firstname"].FormattedValue.ToString();
                        label9.Text = dg.Rows[e.RowIndex].Cells["Lastname"].FormattedValue.ToString();
                        label10.Text = dg.Rows[e.RowIndex].Cells["Middlename"].FormattedValue.ToString();
                        label11.Text = dg.Rows[e.RowIndex].Cells["positionName"].FormattedValue.ToString();
                        label12.Text = dg.Rows[e.RowIndex].Cells["branchName"].FormattedValue.ToString();
                        MemoryStream ms = new MemoryStream((byte[])dg.CurrentRow.Cells["photo"].Value);
                        pictureBox1.Image = Image.FromStream(ms);
                    }


                }
                else
                    MessageBox.Show("empity data");
            }
            catch (Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void Dg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
