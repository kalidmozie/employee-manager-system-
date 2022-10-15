namespace employee_manager
{
    partial class delete
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(delete));
            this.label1 = new System.Windows.Forms.Label();
            this.Ddgv = new System.Windows.Forms.DataGridView();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.searchbtn = new ns1.BunifuImageButton();
            this.delID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Ddgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employee id";
            // 
            // Ddgv
            // 
            this.Ddgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(115)))), ((int)(((byte)(118)))));
            this.Ddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ddgv.Location = new System.Drawing.Point(23, 174);
            this.Ddgv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Ddgv.Name = "Ddgv";
            this.Ddgv.RowHeadersWidth = 51;
            this.Ddgv.Size = new System.Drawing.Size(807, 192);
            this.Ddgv.TabIndex = 2;
            this.Ddgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ddgv_CellClick);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(732, 373);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(97, 59);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.BunifuImageButton1_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.Transparent;
            this.searchbtn.Image = ((System.Drawing.Image)(resources.GetObject("searchbtn.Image")));
            this.searchbtn.ImageActive = null;
            this.searchbtn.Location = new System.Drawing.Point(571, 75);
            this.searchbtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(97, 59);
            this.searchbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchbtn.TabIndex = 4;
            this.searchbtn.TabStop = false;
            this.searchbtn.Zoom = 10;
            this.searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // delID
            // 
            this.delID.Location = new System.Drawing.Point(261, 94);
            this.delID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delID.Name = "delID";
            this.delID.Size = new System.Drawing.Size(280, 22);
            this.delID.TabIndex = 5;
            this.delID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(115)))), ((int)(((byte)(105)))));
            this.Controls.Add(this.delID);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.Ddgv);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "delete";
            this.Size = new System.Drawing.Size(853, 628);
            ((System.ComponentModel.ISupportInitialize)(this.Ddgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchbtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView Ddgv;
        private ns1.BunifuImageButton bunifuImageButton1;
        private ns1.BunifuImageButton searchbtn;
        private System.Windows.Forms.TextBox delID;
    }
}
