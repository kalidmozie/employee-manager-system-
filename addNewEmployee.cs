using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_manager
{
    public partial class addNewEmployee : UserControl
    {
        DBLayer dbl = new DBLayer();
        public addNewEmployee()
        {
            
            InitializeComponent();
            this.phone2.Visible = false;
            this.phone2.Enabled = false;
            this.metroComboBox1.DataSource=dbl.getbranch();
            this.metroComboBox1.DisplayMember = "branchName";
            this.metroComboBox2.DataSource = dbl.getfield();
            this.metroComboBox2.DisplayMember = "fieldName";
            this.metroComboBox3.DataSource = dbl.getposition();
            this.metroComboBox3.DisplayMember = "positionName";

        }
        string imgloc;
        OpenFileDialog img = new OpenFileDialog();
        ToolTip ToolTip1 = new ToolTip();
        

        private void L1_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateTime;
            dateTime = bunifuDatepicker1.Value;
        }

        private void BunifuDatepicker2_TabIndexChanged(object sender, EventArgs e)
        {
            DateTime dateTime;
            dateTime = bunifuDatepicker2.Value;
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            img.Filter = "image files|*.jpg;*.jpeg;*.img;*.png;";

            if (img.ShowDialog() == DialogResult.OK)
            {
                l1.Text = img.FileName;
                photo.Image = Image.FromFile(img.FileName);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {


            img.Filter = "image files|*.jpg;*.jpeg;*.img;*.png;";
            if (img.ShowDialog() == DialogResult.OK)
            {
                l1.Text = img.FileName;
                photo.Image = Image.FromFile(img.FileName);
            }
        }

        private void BunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }

        private void Clrbtn_Click(object sender, EventArgs e)
        {
            photo.Image = null;
        }

        private void Phone2_MouseHover(object sender, EventArgs e)
        {

            ToolTip1.SetToolTip(this.phone2, "Optional phone number");
        }

        private void Photo_DragDrop(object sender, DragEventArgs e)
        {
            var date = e.Data.GetData(DataFormats.FileDrop);
            if (date != null)
            {
                var filename = date as string[];
                if (filename.Length > 0)
                {
                    photo.Image = Image.FromFile(filename[0]);
                    l1.Text = filename[0];
                }
            }
        }

        private void Photo_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.photo, "you can drag and drop images");
        }

        private void AddNewEmployee_Load(object sender, EventArgs e)
        {
            photo.AllowDrop = true;
        }

        private void Photo_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;

        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            User user = new User();
            DBLayer dbl = new DBLayer();
            imgloc = img.FileName;
            MemoryStream ms = new MemoryStream();
            photo.Image.Save(ms, photo.Image.RawFormat);
            user.fname = firstname.Text.ToString();
            user.lname = lastname.Text.ToString();
            user.mname = middlename.Text.ToString();
            user.email = email.Text.ToString();
            if (radioButton1.Checked == true)
                user.gender = "MALE";
            if (radioButton2.Checked == true)
                user.gender = "FEMALE";
            user.DTB = bunifuDatepicker1.Value;
            user.DTR = bunifuDatepicker2.Value;
            user.office = metroComboBox1.Text.ToString();
            user.field = metroComboBox2.Text.ToString();
            user.posistion =metroComboBox3.Text.ToString();
            user.phone1 = int.Parse(phone1.Text.ToString());
            if (phone2.Text!="") user.phone2 = int.Parse(phone2.Text.ToString());
            user.salary = double.Parse(salary.Text);
            if (cb1.Checked == true)
                user.benefit += " 1";
            if (cb3.Checked == true)
                user.benefit += " 3";
            if (cb2.Checked == true)
                user.benefit += " 2";
            if (cb4.Checked == true)
                user.benefit += " 4";
            user.empic = ms.ToArray();
            dbl.AddNew(user);
            MessageBox.Show("added");

            firstname.Text = "";lastname.Text = ""; middlename.Text = "";email.Text = "";phone1.Text = "";phone2.Text = "";salary.Text = "";photo.Image=null;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.phone2.Visible = true;
            this.phone2.Enabled = true;
        }

        private void Firstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
