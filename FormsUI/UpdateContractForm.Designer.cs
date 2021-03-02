namespace FormsUI
{
    partial class UpdateContractForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.winExit = new FontAwesome.Sharp.IconButton();
            this.winMin = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUpgrade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlyPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.winExit);
            this.panel1.Controls.Add(this.winMin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 68);
            this.panel1.TabIndex = 0;
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
            this.winExit.Location = new System.Drawing.Point(364, 2);
            this.winExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winExit.Name = "winExit";
            this.winExit.Rotation = 0D;
            this.winExit.Size = new System.Drawing.Size(23, 23);
            this.winExit.TabIndex = 9;
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
            this.winMin.Location = new System.Drawing.Point(336, 2);
            this.winMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.winMin.Name = "winMin";
            this.winMin.Rotation = 0D;
            this.winMin.Size = new System.Drawing.Size(23, 23);
            this.winMin.TabIndex = 8;
            this.winMin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.winMin.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.label1.Location = new System.Drawing.Point(91, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Upgrade Contract";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearch.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearch.IconSize = 25;
            this.btnSearch.Location = new System.Drawing.Point(129, 166);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(137, 46);
            this.btnSearch.TabIndex = 37;
            this.btnSearch.Text = "Upgrade";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(49, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 18);
            this.label6.TabIndex = 72;
            this.label6.Text = "UpgradeOptions";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 74;
            this.label2.Text = "New Monthly Price";
            // 
            // cmbUpgrade
            // 
            this.cmbUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.cmbUpgrade.ForeColor = System.Drawing.Color.White;
            this.cmbUpgrade.FormattingEnabled = true;
            this.cmbUpgrade.Location = new System.Drawing.Point(172, 89);
            this.cmbUpgrade.Name = "cmbUpgrade";
            this.cmbUpgrade.Size = new System.Drawing.Size(121, 24);
            this.cmbUpgrade.TabIndex = 75;
            this.cmbUpgrade.SelectedIndexChanged += new System.EventHandler(this.cmbUpgrade_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(152, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 18);
            this.label3.TabIndex = 76;
            this.label3.Text = "R";
            // 
            // lblMonthlyPrice
            // 
            this.lblMonthlyPrice.AutoSize = true;
            this.lblMonthlyPrice.Location = new System.Drawing.Point(172, 130);
            this.lblMonthlyPrice.Name = "lblMonthlyPrice";
            this.lblMonthlyPrice.Size = new System.Drawing.Size(0, 17);
            this.lblMonthlyPrice.TabIndex = 77;
            // 
            // UpdateContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(392, 232);
            this.Controls.Add(this.lblMonthlyPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbUpgrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateContractForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateContractForm";
            this.Load += new System.EventHandler(this.UpdateContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton winExit;
        private FontAwesome.Sharp.IconButton winMin;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUpgrade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMonthlyPrice;
    }
}