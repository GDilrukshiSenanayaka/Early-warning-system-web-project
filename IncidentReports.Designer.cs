namespace DisasterManagementSystem
{
    partial class IncidentReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentReports));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reports = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.village = new System.Windows.Forms.Label();
            this.txtlcation = new System.Windows.Forms.TextBox();
            this.txtdist = new System.Windows.Forms.TextBox();
            this.district = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.cmbtype = new System.Windows.Forms.ComboBox();
            this.txtdesc = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.lblimage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.upload = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.reports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 100);
            this.panel1.TabIndex = 0;
            // 
            // reports
            // 
            this.reports.AutoSize = true;
            this.reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reports.ForeColor = System.Drawing.Color.White;
            this.reports.Location = new System.Drawing.Point(411, 26);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(167, 46);
            this.reports.TabIndex = 39;
            this.reports.Text = "Reports";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.submit);
            this.panel2.Controls.Add(this.upload);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lblimage);
            this.panel2.Controls.Add(this.txtdesc);
            this.panel2.Controls.Add(this.description);
            this.panel2.Controls.Add(this.cmbtype);
            this.panel2.Controls.Add(this.type);
            this.panel2.Controls.Add(this.txtdist);
            this.panel2.Controls.Add(this.district);
            this.panel2.Controls.Add(this.txtlcation);
            this.panel2.Controls.Add(this.village);
            this.panel2.Location = new System.Drawing.Point(13, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 239);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 352);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(976, 298);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // village
            // 
            this.village.AutoSize = true;
            this.village.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.village.Location = new System.Drawing.Point(22, 25);
            this.village.Name = "village";
            this.village.Size = new System.Drawing.Size(87, 28);
            this.village.TabIndex = 0;
            this.village.Text = "Location";
            // 
            // txtlcation
            // 
            this.txtlcation.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcation.Location = new System.Drawing.Point(210, 22);
            this.txtlcation.Name = "txtlcation";
            this.txtlcation.Size = new System.Drawing.Size(245, 34);
            this.txtlcation.TabIndex = 3;
            // 
            // txtdist
            // 
            this.txtdist.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdist.Location = new System.Drawing.Point(210, 73);
            this.txtdist.Name = "txtdist";
            this.txtdist.Size = new System.Drawing.Size(245, 34);
            this.txtdist.TabIndex = 5;
            // 
            // district
            // 
            this.district.AutoSize = true;
            this.district.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.Location = new System.Drawing.Point(22, 76);
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(74, 28);
            this.district.TabIndex = 4;
            this.district.Text = "District";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type.Location = new System.Drawing.Point(22, 127);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(128, 28);
            this.type.TabIndex = 6;
            this.type.Text = "Incident Type";
            // 
            // cmbtype
            // 
            this.cmbtype.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbtype.FormattingEnabled = true;
            this.cmbtype.Items.AddRange(new object[] {
            "Flood",
            "Landslide",
            "Earthquakes",
            "Tsunami",
            "Drought",
            "Cyclone"});
            this.cmbtype.Location = new System.Drawing.Point(210, 130);
            this.cmbtype.Name = "cmbtype";
            this.cmbtype.Size = new System.Drawing.Size(245, 36);
            this.cmbtype.TabIndex = 7;
            // 
            // txtdesc
            // 
            this.txtdesc.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesc.Location = new System.Drawing.Point(210, 183);
            this.txtdesc.Multiline = true;
            this.txtdesc.Name = "txtdesc";
            this.txtdesc.Size = new System.Drawing.Size(245, 34);
            this.txtdesc.TabIndex = 9;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(22, 186);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(112, 28);
            this.description.TabIndex = 8;
            this.description.Text = "Description";
            // 
            // lblimage
            // 
            this.lblimage.AutoSize = true;
            this.lblimage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimage.Location = new System.Drawing.Point(530, 28);
            this.lblimage.Name = "lblimage";
            this.lblimage.Size = new System.Drawing.Size(66, 28);
            this.lblimage.TabIndex = 10;
            this.lblimage.Text = "Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(675, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(675, 168);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(111, 46);
            this.upload.TabIndex = 12;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // submit
            // 
            this.submit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.Location = new System.Drawing.Point(825, 168);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(111, 46);
            this.submit.TabIndex = 13;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(945, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // IncidentReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IncidentReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IncidentReports";
            this.Load += new System.EventHandler(this.IncidentReports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label reports;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox txtdist;
        private System.Windows.Forms.Label district;
        private System.Windows.Forms.TextBox txtlcation;
        private System.Windows.Forms.Label village;
        private System.Windows.Forms.ComboBox cmbtype;
        private System.Windows.Forms.TextBox txtdesc;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button upload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblimage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}