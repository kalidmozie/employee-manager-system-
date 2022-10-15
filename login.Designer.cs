namespace employee_manager
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel1 = new ns1.BunifuCustomLabel();
            this.bunifuImageButton2 = new ns1.BunifuImageButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuImageButton3 = new ns1.BunifuImageButton();
            this.password = new ns1.BunifuMetroTextbox();
            this.username = new ns1.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bunifuCustomLabel1
            // 
            resources.ApplyResources(this.bunifuCustomLabel1, "bunifuCustomLabel1");
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuImageButton2, "bunifuImageButton2");
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.BunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.bunifuImageButton1, "bunifuImageButton1");
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.bunifuImageButton3, "bunifuImageButton3");
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.password, "password");
            this.password.BorderColorFocused = System.Drawing.Color.DarkSlateGray;
            this.password.BorderColorIdle = System.Drawing.Color.Gray;
            this.password.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.password.BorderThickness = 5;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.isPassword = true;
            this.password.Name = "password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.Color.Gainsboro;
            resources.ApplyResources(this.username, "username");
            this.username.BorderColorFocused = System.Drawing.Color.DarkSlateGray;
            this.username.BorderColorIdle = System.Drawing.Color.Gray;
            this.username.BorderColorMouseHover = System.Drawing.Color.DarkGray;
            this.username.BorderThickness = 5;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.isPassword = false;
            this.username.Name = "username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(94)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuCustomLabel bunifuCustomLabel1;
        private ns1.BunifuImageButton bunifuImageButton2;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton bunifuImageButton3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuMetroTextbox password;
        private ns1.BunifuMetroTextbox username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}