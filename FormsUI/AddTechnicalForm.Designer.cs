namespace FormsUI
{
    partial class AddTechnicalForm
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
            this.winExit = new FontAwesome.Sharp.IconButton();
            this.cmbSpecialization = new System.Windows.Forms.ComboBox();
            this.btnInsertTech = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTechDeployDate = new System.Windows.Forms.TextBox();
            this.txtTechDeployed = new System.Windows.Forms.TextBox();
            this.txtTechSurname = new System.Windows.Forms.TextBox();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.winMin = new FontAwesome.Sharp.IconButton();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // winExit
            // 
            this.winExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.winExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.winExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.winExit.ForeColor = System.Drawing.Color.Black;
            this.winExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.winExit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.winExit.IconSize = 20;
            this.winExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winExit.Location = new System.Drawing.Point(485, 2);
            this.winExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winExit.Name = "winExit";
            this.winExit.Rotation = 0D;
            this.winExit.Size = new System.Drawing.Size(23, 23);
            this.winExit.TabIndex = 7;
            this.winExit.UseVisualStyleBackColor = false;
            this.winExit.Click += new System.EventHandler(this.winExit_Click);
            // 
            // cmbSpecialization
            // 
            this.cmbSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.cmbSpecialization.ForeColor = System.Drawing.Color.White;
            this.cmbSpecialization.FormattingEnabled = true;
            this.cmbSpecialization.Items.AddRange(new object[] {
            "HandsFree Systems",
            "Defense Systems",
            "Luxurary Systems",
            "Security Systems",
            "Pandemic Systems"});
            this.cmbSpecialization.Location = new System.Drawing.Point(257, 242);
            this.cmbSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSpecialization.Name = "cmbSpecialization";
            this.cmbSpecialization.Size = new System.Drawing.Size(148, 24);
            this.cmbSpecialization.TabIndex = 90;
            // 
            // btnInsertTech
            // 
            this.btnInsertTech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInsertTech.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnInsertTech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertTech.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnInsertTech.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertTech.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnInsertTech.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnInsertTech.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnInsertTech.IconSize = 25;
            this.btnInsertTech.Location = new System.Drawing.Point(184, 296);
            this.btnInsertTech.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsertTech.Name = "btnInsertTech";
            this.btnInsertTech.Rotation = 0D;
            this.btnInsertTech.Size = new System.Drawing.Size(148, 50);
            this.btnInsertTech.TabIndex = 88;
            this.btnInsertTech.Text = "Insert";
            this.btnInsertTech.UseVisualStyleBackColor = false;
            this.btnInsertTech.Click += new System.EventHandler(this.btnInsertTech_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.iconPictureBox1.IconSize = 43;
            this.iconPictureBox1.Location = new System.Drawing.Point(16, 15);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(53, 43);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(158, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Technical Staff Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(77, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add Staff";
            // 
            // txtTechDeployDate
            // 
            this.txtTechDeployDate.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTechDeployDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtTechDeployDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechDeployDate.ForeColor = System.Drawing.Color.White;
            this.txtTechDeployDate.Location = new System.Drawing.Point(362, 131);
            this.txtTechDeployDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechDeployDate.Name = "txtTechDeployDate";
            this.txtTechDeployDate.Size = new System.Drawing.Size(133, 22);
            this.txtTechDeployDate.TabIndex = 87;
            this.txtTechDeployDate.Text = "NULL";
            // 
            // txtTechDeployed
            // 
            this.txtTechDeployed.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTechDeployed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtTechDeployed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechDeployed.ForeColor = System.Drawing.Color.White;
            this.txtTechDeployed.Location = new System.Drawing.Point(362, 188);
            this.txtTechDeployed.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechDeployed.Name = "txtTechDeployed";
            this.txtTechDeployed.Size = new System.Drawing.Size(133, 22);
            this.txtTechDeployed.TabIndex = 86;
            this.txtTechDeployed.Text = "NO";
            // 
            // txtTechSurname
            // 
            this.txtTechSurname.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTechSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtTechSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechSurname.ForeColor = System.Drawing.Color.White;
            this.txtTechSurname.Location = new System.Drawing.Point(92, 188);
            this.txtTechSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechSurname.Name = "txtTechSurname";
            this.txtTechSurname.Size = new System.Drawing.Size(133, 22);
            this.txtTechSurname.TabIndex = 85;
            // 
            // txtTechName
            // 
            this.txtTechName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtTechName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtTechName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTechName.ForeColor = System.Drawing.Color.White;
            this.txtTechName.Location = new System.Drawing.Point(92, 131);
            this.txtTechName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(133, 22);
            this.txtTechName.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 131);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 83;
            this.label7.Text = "DeployDate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(262, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 82;
            this.label6.Text = "Deployed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 80;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-3, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Surname";
            // 
            // winMin
            // 
            this.winMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.winMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.winMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.winMin.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.winMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.winMin.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.winMin.IconSize = 20;
            this.winMin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winMin.Location = new System.Drawing.Point(457, 2);
            this.winMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winMin.Name = "winMin";
            this.winMin.Rotation = 0D;
            this.winMin.Size = new System.Drawing.Size(23, 23);
            this.winMin.TabIndex = 6;
            this.winMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winMin.UseVisualStyleBackColor = false;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.pnlTop.Controls.Add(this.winExit);
            this.pnlTop.Controls.Add(this.winMin);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.iconPictureBox1);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(512, 78);
            this.pnlTop.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(254, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 91;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(140, 243);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 92;
            this.label8.Text = "Specialization";
            // 
            // AddTechnicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(512, 357);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSpecialization);
            this.Controls.Add(this.btnInsertTech);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTechDeployDate);
            this.Controls.Add(this.txtTechDeployed);
            this.Controls.Add(this.txtTechSurname);
            this.Controls.Add(this.txtTechName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddTechnicalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTechnicalForm";
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton winExit;
        private System.Windows.Forms.ComboBox cmbSpecialization;
        private FontAwesome.Sharp.IconButton btnInsertTech;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTechDeployDate;
        private System.Windows.Forms.TextBox txtTechDeployed;
        private System.Windows.Forms.TextBox txtTechSurname;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton winMin;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
    }
}