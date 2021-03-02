namespace FormsUI
{
    partial class SingInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SingInForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconUser = new FontAwesome.Sharp.IconPictureBox();
            this.iconPass = new FontAwesome.Sharp.IconPictureBox();
            this.IconEmail = new FontAwesome.Sharp.IconPictureBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.winExit = new FontAwesome.Sharp.IconButton();
            this.winMin = new FontAwesome.Sharp.IconButton();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.pnlConfirmPass = new System.Windows.Forms.Panel();
            this.iconConfirmPassword = new FontAwesome.Sharp.IconPictureBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.pnlName = new System.Windows.Forms.Panel();
            this.iconName = new FontAwesome.Sharp.IconPictureBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.pnlSurname = new System.Windows.Forms.Panel();
            this.iconSurname = new FontAwesome.Sharp.IconPictureBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSurname)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // IconUser
            // 
            this.IconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.IconUser.IconColor = System.Drawing.Color.White;
            this.IconUser.Location = new System.Drawing.Point(47, 104);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(42, 32);
            this.IconUser.TabIndex = 3;
            this.IconUser.TabStop = false;
            // 
            // iconPass
            // 
            this.iconPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconPass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPass.IconColor = System.Drawing.Color.White;
            this.iconPass.IconSize = 33;
            this.iconPass.Location = new System.Drawing.Point(47, 275);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(42, 33);
            this.iconPass.TabIndex = 4;
            this.iconPass.TabStop = false;
            // 
            // IconEmail
            // 
            this.IconEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IconEmail.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.IconEmail.IconColor = System.Drawing.Color.White;
            this.IconEmail.IconSize = 33;
            this.IconEmail.Location = new System.Drawing.Point(47, 392);
            this.IconEmail.Name = "IconEmail";
            this.IconEmail.Size = new System.Drawing.Size(42, 33);
            this.IconEmail.TabIndex = 5;
            this.IconEmail.TabStop = false;
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Location = new System.Drawing.Point(92, 136);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(200, 1);
            this.pnlUser.TabIndex = 6;
            // 
            // Username
            // 
            this.Username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.HideSelection = false;
            this.Username.Location = new System.Drawing.Point(95, 113);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(197, 20);
            this.Username.TabIndex = 7;
            this.Username.TabStop = false;
            this.Username.Text = "Username";
            this.Username.Click += new System.EventHandler(this.Username_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(95, 284);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(92, 307);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(200, 1);
            this.pnlPass.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HideSelection = false;
            this.txtEmail.Location = new System.Drawing.Point(95, 401);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TabStop = false;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.White;
            this.pnlEmail.Location = new System.Drawing.Point(92, 424);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(200, 1);
            this.pnlEmail.TabIndex = 10;
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
            this.winExit.Location = new System.Drawing.Point(329, 2);
            this.winExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winExit.Name = "winExit";
            this.winExit.Rotation = 0D;
            this.winExit.Size = new System.Drawing.Size(23, 23);
            this.winExit.TabIndex = 15;
            this.winExit.UseVisualStyleBackColor = false;
            this.winExit.Click += new System.EventHandler(this.winExit_Click);
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
            this.winMin.Location = new System.Drawing.Point(300, 2);
            this.winMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winMin.Name = "winMin";
            this.winMin.Rotation = 0D;
            this.winMin.Size = new System.Drawing.Size(23, 23);
            this.winMin.TabIndex = 14;
            this.winMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winMin.UseVisualStyleBackColor = false;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCreateUser.Location = new System.Drawing.Point(47, 480);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(245, 42);
            this.btnCreateUser.TabIndex = 16;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirm.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirm.ForeColor = System.Drawing.Color.White;
            this.txtConfirm.HideSelection = false;
            this.txtConfirm.Location = new System.Drawing.Point(95, 342);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(197, 20);
            this.txtConfirm.TabIndex = 20;
            this.txtConfirm.TabStop = false;
            this.txtConfirm.Text = "Confirm Password";
            this.txtConfirm.Click += new System.EventHandler(this.txtConfirm_Click);
            // 
            // pnlConfirmPass
            // 
            this.pnlConfirmPass.BackColor = System.Drawing.Color.White;
            this.pnlConfirmPass.Location = new System.Drawing.Point(92, 365);
            this.pnlConfirmPass.Name = "pnlConfirmPass";
            this.pnlConfirmPass.Size = new System.Drawing.Size(200, 1);
            this.pnlConfirmPass.TabIndex = 19;
            // 
            // iconConfirmPassword
            // 
            this.iconConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconConfirmPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconConfirmPassword.IconColor = System.Drawing.Color.White;
            this.iconConfirmPassword.IconSize = 33;
            this.iconConfirmPassword.Location = new System.Drawing.Point(47, 333);
            this.iconConfirmPassword.Name = "iconConfirmPassword";
            this.iconConfirmPassword.Size = new System.Drawing.Size(42, 33);
            this.iconConfirmPassword.TabIndex = 18;
            this.iconConfirmPassword.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.White;
            this.txtName.HideSelection = false;
            this.txtName.Location = new System.Drawing.Point(95, 165);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(197, 20);
            this.txtName.TabIndex = 23;
            this.txtName.TabStop = false;
            this.txtName.Text = "Name";
            this.txtName.Click += new System.EventHandler(this.txtName_Click);
            // 
            // pnlName
            // 
            this.pnlName.BackColor = System.Drawing.Color.White;
            this.pnlName.Location = new System.Drawing.Point(92, 188);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(200, 1);
            this.pnlName.TabIndex = 22;
            // 
            // iconName
            // 
            this.iconName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconName.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconName.IconColor = System.Drawing.Color.White;
            this.iconName.Location = new System.Drawing.Point(47, 156);
            this.iconName.Name = "iconName";
            this.iconName.Size = new System.Drawing.Size(42, 32);
            this.iconName.TabIndex = 21;
            this.iconName.TabStop = false;
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSurname.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.ForeColor = System.Drawing.Color.White;
            this.txtSurname.HideSelection = false;
            this.txtSurname.Location = new System.Drawing.Point(95, 225);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(197, 20);
            this.txtSurname.TabIndex = 26;
            this.txtSurname.TabStop = false;
            this.txtSurname.Text = "Surname";
            this.txtSurname.Click += new System.EventHandler(this.txtSurname_Click);
            // 
            // pnlSurname
            // 
            this.pnlSurname.BackColor = System.Drawing.Color.White;
            this.pnlSurname.Location = new System.Drawing.Point(92, 248);
            this.pnlSurname.Name = "pnlSurname";
            this.pnlSurname.Size = new System.Drawing.Size(200, 1);
            this.pnlSurname.TabIndex = 25;
            // 
            // iconSurname
            // 
            this.iconSurname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconSurname.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconSurname.IconColor = System.Drawing.Color.White;
            this.iconSurname.Location = new System.Drawing.Point(47, 216);
            this.iconSurname.Name = "iconSurname";
            this.iconSurname.Size = new System.Drawing.Size(42, 32);
            this.iconSurname.TabIndex = 24;
            this.iconSurname.TabStop = false;
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.lblSuccess.Location = new System.Drawing.Point(89, 450);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(167, 17);
            this.lblSuccess.TabIndex = 27;
            this.lblSuccess.Text = "User Created Succesfully";
            this.lblSuccess.Visible = false;
            // 
            // SingInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(352, 535);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.pnlSurname);
            this.Controls.Add(this.iconSurname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlName);
            this.Controls.Add(this.iconName);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.pnlConfirmPass);
            this.Controls.Add(this.iconConfirmPassword);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.winExit);
            this.Controls.Add(this.winMin);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.IconEmail);
            this.Controls.Add(this.iconPass);
            this.Controls.Add(this.IconUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SingInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSurname)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox IconUser;
        private FontAwesome.Sharp.IconPictureBox iconPass;
        private FontAwesome.Sharp.IconPictureBox IconEmail;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnlEmail;
        private FontAwesome.Sharp.IconButton winExit;
        private FontAwesome.Sharp.IconButton winMin;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Panel pnlConfirmPass;
        private FontAwesome.Sharp.IconPictureBox iconConfirmPassword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel pnlName;
        private FontAwesome.Sharp.IconPictureBox iconName;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Panel pnlSurname;
        private FontAwesome.Sharp.IconPictureBox iconSurname;
        private System.Windows.Forms.Label lblSuccess;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}