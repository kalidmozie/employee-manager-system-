using System;
//using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_manager
{
    public partial class edit : UserControl
    {
        string role, field;
        OpenFileDialog img = new OpenFileDialog();
        ToolTip ToolTip1 = new ToolTip();
        public edit(string R, string F)
        {
            InitializeComponent();
            DBLayer dbl = new DBLayer();
            profession.DataSource = dbl.getfield();
            office.DataSource = dbl.getbranch();
            profession.DisplayMember = "fieldName";
            office.DisplayMember = "branchName";
            this.role = R;
            this.field = F;

            if (idbox.Text == "") srh.Visible=false;
            if (idbox.Text != null) srh.Visible = true;
        }


            private void Photo_Click(object sender, EventArgs e)
        {

            img.Filter = "image files|*.jpg;*.jpeg;*.img;*.png;";
            if (img.ShowDialog() == DialogResult.OK)
            {
                photo.Image = Image.FromFile(img.FileName);
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            img.Filter = "image files|*.jpg;*.jpeg;*.img;*.png;";
            if (img.ShowDialog() == DialogResult.OK)
            {
                photo.Image = Image.FromFile(img.FileName);
            }

        }

        private void BunifuFlatButton1_MouseHover(object sender, EventArgs e)
        {
            ToolTip1.SetToolTip(this.photo, img.FileName);
        }

        private void Edit_Load(object sender, EventArgs e)
        {

        }

        private void Dataview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Dataview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {

                    dv.CurrentRow.Selected = true;
                    fname.Text = dv.Rows[e.RowIndex].Cells["firstname"].FormattedValue.ToString();
                    lname.Text = dv.Rows[e.RowIndex].Cells["Lastname"].FormattedValue.ToString();
                    mname.Text = dv.Rows[e.RowIndex].Cells["Middlename"].FormattedValue.ToString();
                    eml.Text = dv.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                    ph1.Text = dv.Rows[e.RowIndex].Cells["primarynumber"].FormattedValue.ToString();
                    phn2.Text = dv.Rows[e.RowIndex].Cells["secondarynumber"].FormattedValue.ToString();
                    if (dv.CurrentRow.Cells["photo"].Value == null)
                    {
                        photo.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream((byte[])dv.CurrentRow.Cells["photo"].Value);
                        photo.Image = Image.FromStream(ms);
                    }
                }
            }
        }

        private void Dv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex <= 0)
                {
                    if (dv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {

                        dv.CurrentRow.Selected = true;
                        fname.Text = dv.Rows[e.RowIndex].Cells["firstname"].FormattedValue.ToString();
                        lname.Text = dv.Rows[e.RowIndex].Cells["Lastname"].FormattedValue.ToString();
                        mname.Text = dv.Rows[e.RowIndex].Cells["Middlename"].FormattedValue.ToString();
                        eml.Text = dv.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                        ph1.Text = dv.Rows[e.RowIndex].Cells["primarynumber"].FormattedValue.ToString();
                        phn2.Text = dv.Rows[e.RowIndex].Cells["secondarynumber"].FormattedValue.ToString();
                        if (dv.Rows[e.RowIndex].Cells["gender"].FormattedValue.ToString() == "MALE")
                            male.Checked = true;
                        else
                            female.Checked = true;
                        if (dv.CurrentRow.Cells["photo"].Value == null)
                        {
                            photo.Image = null;
                        }
                        else
                        {
                            MemoryStream ms = new MemoryStream((byte[])dv.CurrentRow.Cells["photo"].Value);
                            photo.Image = Image.FromStream(ms);
                        }
                    }

                }
            }
            catch(Exception z)
            {
                MessageBox.Show(z.Message);
            }
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            string imgloc;
            User user = new User();
            DBLayer dbl = new DBLayer();
            imgloc = img.FileName;
            MemoryStream ms = new MemoryStream();
            photo.Image.Save(ms, photo.Image.RawFormat);
            user.id = int.Parse(idbox.Text);
            user.fname = fname.Text.ToString();
            user.lname = lname.Text.ToString();
            user.mname = mname.Text.ToString();
            user.email = eml.Text.ToString();
            if (male.Checked == true)
                user.gender = "MALE";
            if (female.Checked == true)
                user.gender = "FEMALE";
            user.DTB = dob.Value;
            user.DTR = rdt.Value;
            user.office = office.Text.ToString();
            user.field =profession.Text.ToString();
            user.phone1 = int.Parse(ph1.Text);
            user.phone2 = int.Parse(phn2.Text);
            user.empic = ms.ToArray();
            dbl.update(user);
            MessageBox.Show("update succsess");
            idbox.Text = ""; fname.Text = ""; lname.Text = ""; mname.Text = "";ph1.Text = "";
            phn2.Text ="";photo.Image = null;eml.Text = "";

        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            DBLayer db = new DBLayer();
            Form1 f1 = new Form1();
            if (idbox.Text.Length == 0) ;

            String query;
           // idbox.Text = "0";
            if (role == "secretary" || role == "administrator")
            {
                query = "exec sppersonselectforAdmin " + int.Parse(idbox.Text);
            }
            else
                query = "exec  spselectbyid " +int.Parse(idbox.Text) + "," + "'" + field +"'";
            DataTable dt = db.getRecords(query);
            dv.DataSource = dt;
        }
    }
}