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
    public partial class addfieldandbranch : UserControl
    {
        public addfieldandbranch()
        {
            InitializeComponent();
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            field fld = new field();
            DBLayer dbl = new DBLayer();
            fld.newField = fldn.Text;
            fld.fieldDesc = fdesc.Text;
            dbl.addField(fld);
        }

        private void BunifuThinButton22_Click(object sender, EventArgs e)
        {
            branch br = new branch();
            DBLayer dbl = new DBLayer();
            br.newBranch = fldn.Text;
            br.branchAdd = fdesc.Text;
            dbl.addBranch(br);

        }
    }
}
