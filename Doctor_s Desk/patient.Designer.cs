
namespace Doctor_s_Desk
{
    partial class patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(patient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.back = new System.Windows.Forms.Button();
            this.searchbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.patientlist = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.prob = new System.Windows.Forms.TextBox();
            this.bp2 = new System.Windows.Forms.NumericUpDown();
            this.bp1 = new System.Windows.Forms.NumericUpDown();
            this.sextxt = new System.Windows.Forms.DomainUpDown();
            this.agetext = new System.Windows.Forms.NumericUpDown();
            this.adrstxt = new System.Windows.Forms.TextBox();
            this.Pphone = new System.Windows.Forms.TextBox();
            this.pName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agetext)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Doctor_s_Desk.Properties.Resources.Good_Doctor;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(790, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Red;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.Location = new System.Drawing.Point(12, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(27, 27);
            this.back.TabIndex = 3;
            this.back.Text = "X";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(185, 27);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(24, 20);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "🔍";
            this.searchbtn.UseVisualStyleBackColor = false;
            this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.searchbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.patientlist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(317, 379);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.key_p);
            // 
            // patientlist
            // 
            this.patientlist.BackColor = System.Drawing.SystemColors.Control;
            this.patientlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientlist.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.patientlist.FormattingEnabled = true;
            this.patientlist.ItemHeight = 20;
            this.patientlist.Location = new System.Drawing.Point(6, 48);
            this.patientlist.Name = "patientlist";
            this.patientlist.ScrollAlwaysVisible = true;
            this.patientlist.Size = new System.Drawing.Size(284, 244);
            this.patientlist.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.add);
            this.panel2.Controls.Add(this.prob);
            this.panel2.Controls.Add(this.bp2);
            this.panel2.Controls.Add(this.bp1);
            this.panel2.Controls.Add(this.sextxt);
            this.panel2.Controls.Add(this.agetext);
            this.panel2.Controls.Add(this.adrstxt);
            this.panel2.Controls.Add(this.Pphone);
            this.panel2.Controls.Add(this.pName);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(317, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 379);
            this.panel2.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(233, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 24);
            this.button1.TabIndex = 17;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(174, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "/";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.DarkOrchid;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.add.Location = new System.Drawing.Point(136, 347);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(59, 24);
            this.add.TabIndex = 15;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // prob
            // 
            this.prob.Location = new System.Drawing.Point(127, 269);
            this.prob.Multiline = true;
            this.prob.Name = "prob";
            this.prob.Size = new System.Drawing.Size(171, 71);
            this.prob.TabIndex = 14;
            // 
            // bp2
            // 
            this.bp2.Location = new System.Drawing.Point(190, 234);
            this.bp2.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.bp2.Name = "bp2";
            this.bp2.Size = new System.Drawing.Size(47, 20);
            this.bp2.TabIndex = 13;
            this.bp2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bp1
            // 
            this.bp1.Location = new System.Drawing.Point(127, 234);
            this.bp1.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.bp1.Name = "bp1";
            this.bp1.Size = new System.Drawing.Size(43, 20);
            this.bp1.TabIndex = 12;
            this.bp1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // sextxt
            // 
            this.sextxt.Items.Add("Male");
            this.sextxt.Items.Add("Female");
            this.sextxt.Items.Add("Other");
            this.sextxt.Location = new System.Drawing.Point(127, 188);
            this.sextxt.Name = "sextxt";
            this.sextxt.Size = new System.Drawing.Size(68, 20);
            this.sextxt.TabIndex = 11;
            this.sextxt.Text = "Other";
            this.sextxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // agetext
            // 
            this.agetext.Location = new System.Drawing.Point(127, 151);
            this.agetext.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.agetext.Name = "agetext";
            this.agetext.Size = new System.Drawing.Size(54, 20);
            this.agetext.TabIndex = 10;
            this.agetext.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // adrstxt
            // 
            this.adrstxt.Location = new System.Drawing.Point(126, 96);
            this.adrstxt.Multiline = true;
            this.adrstxt.Name = "adrstxt";
            this.adrstxt.Size = new System.Drawing.Size(172, 47);
            this.adrstxt.TabIndex = 9;
            // 
            // Pphone
            // 
            this.Pphone.Location = new System.Drawing.Point(126, 69);
            this.Pphone.Name = "Pphone";
            this.Pphone.Size = new System.Drawing.Size(173, 20);
            this.Pphone.TabIndex = 8;
            this.Pphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_only);
            // 
            // pName
            // 
            this.pName.Location = new System.Drawing.Point(126, 36);
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(173, 20);
            this.pName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 263);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Problem:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "BP:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Sex:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Phone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Doctor_s_Desk.Properties.Resources.Good_Doctor_BackGround__3_;
            this.ClientSize = new System.Drawing.Size(790, 435);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor\'s Desk";
            this.Load += new System.EventHandler(this.patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agetext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox patientlist;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Pphone;
        private System.Windows.Forms.TextBox pName;
        private System.Windows.Forms.NumericUpDown agetext;
        private System.Windows.Forms.TextBox adrstxt;
        private System.Windows.Forms.DomainUpDown sextxt;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox prob;
        private System.Windows.Forms.NumericUpDown bp2;
        private System.Windows.Forms.NumericUpDown bp1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}