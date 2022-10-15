using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_manager
{
    public partial class login : Form
    {
        public string fld;
        public login()
        {
            InitializeComponent();
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Password_OnTextChange(object sender, EventArgs e)
        {
            
        }

        private void BunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void BunifuImageButton3_Click(object sender, EventArgs e)
        {

                DBLayer dbl = new DBLayer();

                DataTable dt1 = dbl.getRole(username.Text, password.Text);
                if (dt1.Rows.Count == 0)
                {
                    MessageBox.Show("invalid Login");
                    username.Text = "";
                    password.Text = "";
                }
                else
                {
                    
                    this.Hide();
                    string usr = dt1.Rows[0][2].ToString();
                    string pwd = dt1.Rows[0][3].ToString();
                    string role = dt1.Rows[0][0].ToString();
                    string field = dt1.Rows[0][1].ToString();
                    Form1 F = new Form1(role,field,usr,pwd);
                    F.Show();

                }
            

        }
    }
}
