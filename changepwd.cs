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
    public partial class changepwd : UserControl
    {
        string usr, pwd, fld;
        public changepwd(string U, string P, string F)
        {
            InitializeComponent();
            change.Text = "change";
            this.usr = U;
            this.pwd = P;
            this.fld = F;
        }
            private void Change_Click(object sender, EventArgs e)
        {
            if (string.Equals(pwd,(old.Text.ToString())))
            {
                if (string.Equals((new1.Text.ToString()),(new2.Text.ToString())))
                {
                    pwd = new2.Text;
                    DBLayer dbl = new DBLayer();
                    dbl.updatepwd(usr, fld, pwd);
                    MessageBox.Show("password sucsessfully updated", "password");
                }
                else
                    MessageBox.Show("password dosent match", "password");

            }
            else
                MessageBox.Show("password incorrect", "password");
        }

    }
    
}
