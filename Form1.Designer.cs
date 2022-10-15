namespace employee_manager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.taskpanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton21 = new ns1.BunifuThinButton2();
            this.mngbtn = new ns1.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.addbf = new ns1.BunifuFlatButton();
            this.deletebtn = new ns1.BunifuFlatButton();
            this.updatebtn = new ns1.BunifuFlatButton();
            this.viwebtn = new ns1.BunifuFlatButton();
            this.addbtn = new ns1.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.taskpanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.bunifuImageButton1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1075, 55);
            this.panel2.TabIndex = 1;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.BackgroundImage")));
            this.bunifuImageButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuImageButton1.ErrorImage = null;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(1012, 4);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(47, 44);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            this.bunifuImageButton1.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.EXIT);
            this.bunifuImageButton1.MouseHover += new System.EventHandler(this.BunifuImageButton1_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Gothic", 22.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(557, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOME TO EMPLOYEE MANAGER";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // taskpanel
            // 
            this.taskpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(80)))));
            this.taskpanel.Controls.Add(this.label9);
            this.taskpanel.Controls.Add(this.label8);
            this.taskpanel.Controls.Add(this.label7);
            this.taskpanel.Controls.Add(this.label6);
            this.taskpanel.Controls.Add(this.label5);
            this.taskpanel.Controls.Add(this.label4);
            this.taskpanel.Controls.Add(this.label3);
            this.taskpanel.Controls.Add(this.bunifuThinButton21);
            this.taskpanel.Controls.Add(this.mngbtn);
            this.taskpanel.Controls.Add(this.label1);
            this.taskpanel.Controls.Add(this.addbf);
            this.taskpanel.Controls.Add(this.deletebtn);
            this.taskpanel.Controls.Add(this.updatebtn);
            this.taskpanel.Controls.Add(this.viwebtn);
            this.taskpanel.Controls.Add(this.addbtn);
            this.taskpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.taskpanel.Location = new System.Drawing.Point(0, 55);
            this.taskpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taskpanel.Name = "taskpanel";
            this.taskpanel.Size = new System.Drawing.Size(221, 628);
            this.taskpanel.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label9.Location = new System.Drawing.Point(196, 439);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = ">";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label8.Location = new System.Drawing.Point(196, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = ">";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label7.Location = new System.Drawing.Point(196, 284);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = ">";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label6.Location = new System.Drawing.Point(196, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = ">";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(196, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = ">";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Location = new System.Drawing.Point(196, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = ">";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(131, 4);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Field";
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.PaleVioletRed;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(80)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuThinButton21.ButtonText = "LOG OUT";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.OrangeRed;
            this.bunifuThinButton21.Location = new System.Drawing.Point(24, 580);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(190, 41);
            this.bunifuThinButton21.TabIndex = 8;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // mngbtn
            // 
            this.mngbtn.Activecolor = System.Drawing.Color.Gray;
            this.mngbtn.BackColor = System.Drawing.Color.Silver;
            this.mngbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mngbtn.BorderRadius = 0;
            this.mngbtn.ButtonText = "Manage BENEFITS";
            this.mngbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mngbtn.DisabledColor = System.Drawing.Color.Gray;
            this.mngbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.mngbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("mngbtn.Iconimage")));
            this.mngbtn.Iconimage_right = null;
            this.mngbtn.Iconimage_right_Selected = null;
            this.mngbtn.Iconimage_Selected = null;
            this.mngbtn.IconMarginLeft = 0;
            this.mngbtn.IconMarginRight = 0;
            this.mngbtn.IconRightVisible = true;
            this.mngbtn.IconRightZoom = 0D;
            this.mngbtn.IconVisible = true;
            this.mngbtn.IconZoom = 90D;
            this.mngbtn.IsTab = false;
            this.mngbtn.Location = new System.Drawing.Point(0, 439);
            this.mngbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.mngbtn.Name = "mngbtn";
            this.mngbtn.Normalcolor = System.Drawing.Color.Silver;
            this.mngbtn.OnHovercolor = System.Drawing.Color.Silver;
            this.mngbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.mngbtn.selected = false;
            this.mngbtn.Size = new System.Drawing.Size(221, 59);
            this.mngbtn.TabIndex = 6;
            this.mngbtn.Text = "Manage BENEFITS";
            this.mngbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mngbtn.Textcolor = System.Drawing.Color.Black;
            this.mngbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngbtn.Click += new System.EventHandler(this.Mngbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = " Role";
            // 
            // addbf
            // 
            this.addbf.Activecolor = System.Drawing.Color.Gray;
            this.addbf.BackColor = System.Drawing.Color.Silver;
            this.addbf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addbf.BorderRadius = 0;
            this.addbf.ButtonText = "ADD FILED OR BRANCH";
            this.addbf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbf.DisabledColor = System.Drawing.Color.Gray;
            this.addbf.Iconcolor = System.Drawing.Color.Transparent;
            this.addbf.Iconimage = ((System.Drawing.Image)(resources.GetObject("addbf.Iconimage")));
            this.addbf.Iconimage_right = null;
            this.addbf.Iconimage_right_Selected = null;
            this.addbf.Iconimage_Selected = null;
            this.addbf.IconMarginLeft = 0;
            this.addbf.IconMarginRight = 0;
            this.addbf.IconRightVisible = true;
            this.addbf.IconRightZoom = 0D;
            this.addbf.IconVisible = true;
            this.addbf.IconZoom = 90D;
            this.addbf.IsTab = false;
            this.addbf.Location = new System.Drawing.Point(0, 362);
            this.addbf.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addbf.Name = "addbf";
            this.addbf.Normalcolor = System.Drawing.Color.Silver;
            this.addbf.OnHovercolor = System.Drawing.Color.Silver;
            this.addbf.OnHoverTextColor = System.Drawing.Color.White;
            this.addbf.selected = false;
            this.addbf.Size = new System.Drawing.Size(221, 59);
            this.addbf.TabIndex = 4;
            this.addbf.Text = "ADD FILED OR BRANCH";
            this.addbf.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbf.Textcolor = System.Drawing.Color.Black;
            this.addbf.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbf.Click += new System.EventHandler(this.Addbf_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.Activecolor = System.Drawing.Color.Gray;
            this.deletebtn.BackColor = System.Drawing.Color.Silver;
            this.deletebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebtn.BorderRadius = 0;
            this.deletebtn.ButtonText = "DELETE";
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebtn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deletebtn.Iconimage")));
            this.deletebtn.Iconimage_right = null;
            this.deletebtn.Iconimage_right_Selected = null;
            this.deletebtn.Iconimage_Selected = null;
            this.deletebtn.IconMarginLeft = 0;
            this.deletebtn.IconMarginRight = 0;
            this.deletebtn.IconRightVisible = true;
            this.deletebtn.IconRightZoom = 0D;
            this.deletebtn.IconVisible = true;
            this.deletebtn.IconZoom = 90D;
            this.deletebtn.IsTab = false;
            this.deletebtn.Location = new System.Drawing.Point(0, 284);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Normalcolor = System.Drawing.Color.Silver;
            this.deletebtn.OnHovercolor = System.Drawing.Color.Red;
            this.deletebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebtn.selected = false;
            this.deletebtn.Size = new System.Drawing.Size(221, 59);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.Textcolor = System.Drawing.Color.Black;
            this.deletebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.Activecolor = System.Drawing.Color.Gray;
            this.updatebtn.BackColor = System.Drawing.Color.Silver;
            this.updatebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.updatebtn.BorderRadius = 0;
            this.updatebtn.ButtonText = "UPDATE";
            this.updatebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updatebtn.DisabledColor = System.Drawing.Color.Gray;
            this.updatebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.updatebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("updatebtn.Iconimage")));
            this.updatebtn.Iconimage_right = null;
            this.updatebtn.Iconimage_right_Selected = null;
            this.updatebtn.Iconimage_Selected = null;
            this.updatebtn.IconMarginLeft = 0;
            this.updatebtn.IconMarginRight = 0;
            this.updatebtn.IconRightVisible = true;
            this.updatebtn.IconRightZoom = 0D;
            this.updatebtn.IconVisible = true;
            this.updatebtn.IconZoom = 90D;
            this.updatebtn.IsTab = false;
            this.updatebtn.Location = new System.Drawing.Point(0, 206);
            this.updatebtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Normalcolor = System.Drawing.Color.Silver;
            this.updatebtn.OnHovercolor = System.Drawing.Color.Silver;
            this.updatebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.updatebtn.selected = false;
            this.updatebtn.Size = new System.Drawing.Size(221, 59);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.updatebtn.Textcolor = System.Drawing.Color.Black;
            this.updatebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // viwebtn
            // 
            this.viwebtn.Activecolor = System.Drawing.Color.Gray;
            this.viwebtn.BackColor = System.Drawing.Color.Silver;
            this.viwebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.viwebtn.BorderRadius = 0;
            this.viwebtn.ButtonText = "VIEW";
            this.viwebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.viwebtn.DisabledColor = System.Drawing.Color.Gray;
            this.viwebtn.Iconcolor = System.Drawing.Color.Transparent;
            this.viwebtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("viwebtn.Iconimage")));
            this.viwebtn.Iconimage_right = null;
            this.viwebtn.Iconimage_right_Selected = null;
            this.viwebtn.Iconimage_Selected = null;
            this.viwebtn.IconMarginLeft = 0;
            this.viwebtn.IconMarginRight = 0;
            this.viwebtn.IconRightVisible = true;
            this.viwebtn.IconRightZoom = 0D;
            this.viwebtn.IconVisible = true;
            this.viwebtn.IconZoom = 90D;
            this.viwebtn.IsTab = false;
            this.viwebtn.Location = new System.Drawing.Point(0, 127);
            this.viwebtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.viwebtn.Name = "viwebtn";
            this.viwebtn.Normalcolor = System.Drawing.Color.Silver;
            this.viwebtn.OnHovercolor = System.Drawing.Color.Silver;
            this.viwebtn.OnHoverTextColor = System.Drawing.Color.White;
            this.viwebtn.selected = false;
            this.viwebtn.Size = new System.Drawing.Size(221, 59);
            this.viwebtn.TabIndex = 1;
            this.viwebtn.Text = "VIEW";
            this.viwebtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viwebtn.Textcolor = System.Drawing.Color.Black;
            this.viwebtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viwebtn.Click += new System.EventHandler(this.Viwebtn_Click);
            // 
            // addbtn
            // 
            this.addbtn.Activecolor = System.Drawing.Color.Gray;
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.BackColor = System.Drawing.Color.Silver;
            this.addbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addbtn.BorderRadius = 0;
            this.addbtn.ButtonText = "ADD New Employee";
            this.addbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addbtn.DisabledColor = System.Drawing.Color.Gray;
            this.addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.addbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("addbtn.Iconimage")));
            this.addbtn.Iconimage_right = null;
            this.addbtn.Iconimage_right_Selected = null;
            this.addbtn.Iconimage_Selected = null;
            this.addbtn.IconMarginLeft = 0;
            this.addbtn.IconMarginRight = 0;
            this.addbtn.IconRightVisible = true;
            this.addbtn.IconRightZoom = 0D;
            this.addbtn.IconVisible = true;
            this.addbtn.IconZoom = 90D;
            this.addbtn.IsTab = false;
            this.addbtn.Location = new System.Drawing.Point(0, 46);
            this.addbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.addbtn.Name = "addbtn";
            this.addbtn.Normalcolor = System.Drawing.Color.Silver;
            this.addbtn.OnHovercolor = System.Drawing.Color.Silver;
            this.addbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.addbtn.selected = false;
            this.addbtn.Size = new System.Drawing.Size(221, 56);
            this.addbtn.TabIndex = 0;
            this.addbtn.Text = "ADD New Employee";
            this.addbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addbtn.Textcolor = System.Drawing.Color.Black;
            this.addbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            this.addbtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Addbtn_MouseClick);
            // 
            // panel3
            // 
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(115)))), ((int)(((byte)(105)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.linkLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(221, 55);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(854, 628);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.LightSkyBlue;
            this.linkLabel1.Location = new System.Drawing.Point(636, 598);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(188, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1075, 683);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.taskpanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.taskpanel.ResumeLayout(false);
            this.taskpanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel taskpanel;
        private ns1.BunifuFlatButton deletebtn;
        private ns1.BunifuFlatButton updatebtn;
        private ns1.BunifuFlatButton viwebtn;
        private ns1.BunifuFlatButton addbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuThinButton2 bunifuThinButton21;
        private ns1.BunifuFlatButton mngbtn;
        private ns1.BunifuFlatButton addbf;
        private ns1.BunifuImageButton bunifuImageButton1;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

