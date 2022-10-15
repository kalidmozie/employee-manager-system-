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
    public partial class Form1 : Form
    {
        addNewEmployee ad = new addNewEmployee();
        
        addfieldandbranch bf = new addfieldandbranch();
        delete del = new delete();
        DBLayer dbl = new DBLayer();

        string role, field,usr,pwd;
        public Form1(string role,string field,string usr,string pwd)
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            this.label1.Text = role;
            this.label3.Text = field;
            this.role = role;
            this.field = field;
            this.usr = usr;
            this.pwd = pwd;
          
            if (role.CompareTo("administrator") ==0)
            {
                dbl.url= "server=LAPTOP-054ND8U9;database=EmployeeDatabase;uid=admins;pwd=admin;";

            }
            if (role.CompareTo("Manager") == 0)
            {
                dbl.url = "server=LAPTOP-054ND8U9;database=EmployeeDatabase;uid=MAN;pwd=manager;";
                mngbtn.Visible = false;
                addbf.Visible = false;
                deletebtn.Visible = false;
                ad.metroComboBox2.Text = label3.Text;
                ad.metroComboBox2.Enabled = false;
            }
            if (role.CompareTo("secretary") == 0)
            {
                dbl.url = "server=LAPTOP-054ND8U9;database=EmployeeDatabase;uid=secretorys;pwd=secretary;";
                mngbtn.Visible = false;
                updatebtn.Visible = false;
                addbf.Visible = false;
                deletebtn.Visible = false;
                ad.metroComboBox3.Enabled = false;
                
            }
             string rr()
            {
                return role;
            }

           string Rf()
            {
                return field;
            }

            // this.label3.Text = field;

        }
        public Form1()
        {

         //  InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            this.Controls.Add(ad);
            ad.Location = new Point(166,45);
            
            ad.BringToFront();
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
            
        }

        private void EXIT(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void BunifuImageButton1_MouseHover(object sender, EventArgs e)
        {
           ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.bunifuImageButton1, "EXIT APPLICATION");
        }

        private void Viwebtn_Click(object sender, EventArgs e)
        {
            view vw = new view(role,field);
            this.Controls.Add(vw);
            
            Form1 f1 = new Form1();
            DBLayer db = new DBLayer();
            login log = new login();
            
            String query;
            if (role == "secretary" || role == "administrator")
            {
                query = "exec spSelectAll";
            }
            else
                query = "exec spSelectEmploye " + "'" + field + "'";
            DataTable dt = db.getRecords(query);
            vw.dg.DataSource = dt;
            vw.Location = new Point(166, 45);
            vw.BringToFront();
            label4.Visible = false;
            label5.Visible = true;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

        }

        private void Addbtn_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void BunifuThinButton21_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            edit ed = new edit(role, field);
            this.Controls.Add(ed);
            ed.Location = new Point(166, 45);
            ed.BringToFront();
            this.updatebtn.BackColor= Color.Green;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;

        }

        private void Addbf_Click(object sender, EventArgs e)
        {
            this.Controls.Add(bf);
            bf.Location = new Point(166, 45);
            bf.BringToFront();

            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = true;
            label9.Visible = false;
        }

        private void Mngbtn_Click(object sender, EventArgs e)
        {


            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = true;
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            this.Controls.Add(del);
            del.Location = new Point(166, 45);
            del.BringToFront();
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = true;
            label8.Visible = false;
            label9.Visible = false;
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            changepwd cp = new changepwd(usr, pwd, field);
            this.Controls.Add(cp);
            cp.Location = new Point(366, 145);
            cp.BringToFront();
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Bu_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }
    }
}
