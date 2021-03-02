namespace FormsUI
{
    partial class LogInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.winExit = new FontAwesome.Sharp.IconButton();
            this.winMin = new FontAwesome.Sharp.IconButton();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlPass = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.iconPass = new FontAwesome.Sharp.IconPictureBox();
            this.IconUser = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnLogin.Location = new System.Drawing.Point(61, 246);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 42);
            this.btnLogin.TabIndex = 40;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnCreateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateUser.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnCreateUser.Location = new System.Drawing.Point(61, 294);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(245, 42);
            this.btnCreateUser.TabIndex = 39;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = false;
            this.btnCreateUser.Click += new System.EventHandler(this.button1_Click);
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
            this.winExit.Location = new System.Drawing.Point(351, 1);
            this.winExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winExit.Name = "winExit";
            this.winExit.Rotation = 0D;
            this.winExit.Size = new System.Drawing.Size(23, 23);
            this.winExit.TabIndex = 38;
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
            this.winMin.Location = new System.Drawing.Point(322, 1);
            this.winMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winMin.Name = "winMin";
            this.winMin.Rotation = 0D;
            this.winMin.Size = new System.Drawing.Size(23, 23);
            this.winMin.TabIndex = 37;
            this.winMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winMin.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HideSelection = false;
            this.txtPassword.Location = new System.Drawing.Point(109, 189);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(197, 20);
            this.txtPassword.TabIndex = 34;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // pnlPass
            // 
            this.pnlPass.BackColor = System.Drawing.Color.White;
            this.pnlPass.Location = new System.Drawing.Point(106, 212);
            this.pnlPass.Name = "pnlPass";
            this.pnlPass.Size = new System.Drawing.Size(200, 1);
            this.pnlPass.TabIndex = 33;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HideSelection = false;
            this.txtUsername.Location = new System.Drawing.Point(109, 137);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(197, 20);
            this.txtUsername.TabIndex = 32;
            this.txtUsername.TabStop = false;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // pnlUser
            // 
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.Location = new System.Drawing.Point(106, 160);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(200, 1);
            this.pnlUser.TabIndex = 31;
            // 
            // iconPass
            // 
            this.iconPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.iconPass.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.iconPass.IconColor = System.Drawing.Color.White;
            this.iconPass.IconSize = 33;
            this.iconPass.Location = new System.Drawing.Point(61, 180);
            this.iconPass.Name = "iconPass";
            this.iconPass.Size = new System.Drawing.Size(42, 33);
            this.iconPass.TabIndex = 29;
            this.iconPass.TabStop = false;
            // 
            // IconUser
            // 
            this.IconUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.IconUser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.IconUser.IconColor = System.Drawing.Color.White;
            this.IconUser.Location = new System.Drawing.Point(61, 128);
            this.IconUser.Name = "IconUser";
            this.IconUser.Size = new System.Drawing.Size(42, 32);
            this.IconUser.TabIndex = 28;
            this.IconUser.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(375, 380);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCreateUser);
            this.Controls.Add(this.winExit);
            this.Controls.Add(this.winMin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.pnlPass);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.iconPass);
            this.Controls.Add(this.IconUser);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)(this.iconPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCreateUser;
        private FontAwesome.Sharp.IconButton winExit;
        private FontAwesome.Sharp.IconButton winMin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlPass;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlUser;
        private FontAwesome.Sharp.IconPictureBox iconPass;
        private FontAwesome.Sharp.IconPictureBox IconUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}