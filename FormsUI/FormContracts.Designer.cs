namespace FormsUI
{
    partial class FormContracts
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
            this.btnServiceLevels = new FontAwesome.Sharp.IconButton();
            this.btnContractTypes = new FontAwesome.Sharp.IconButton();
            this.lblActiveContracts = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddContractType = new FontAwesome.Sharp.IconButton();
            this.btnUpdateContract = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddOrder = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.btnServiceLevels);
            this.panel1.Controls.Add(this.btnContractTypes);
            this.panel1.Controls.Add(this.lblActiveContracts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 72);
            this.panel1.TabIndex = 0;
            // 
            // btnServiceLevels
            // 
            this.btnServiceLevels.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnServiceLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnServiceLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceLevels.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnServiceLevels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServiceLevels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnServiceLevels.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnServiceLevels.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnServiceLevels.IconSize = 25;
            this.btnServiceLevels.Location = new System.Drawing.Point(118, 31);
            this.btnServiceLevels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnServiceLevels.Name = "btnServiceLevels";
            this.btnServiceLevels.Rotation = 0D;
            this.btnServiceLevels.Size = new System.Drawing.Size(185, 32);
            this.btnServiceLevels.TabIndex = 30;
            this.btnServiceLevels.Text = "View Service Levels";
            this.btnServiceLevels.UseVisualStyleBackColor = false;
            this.btnServiceLevels.Click += new System.EventHandler(this.btnServiceLevels_Click);
            // 
            // btnContractTypes
            // 
            this.btnContractTypes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnContractTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnContractTypes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContractTypes.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnContractTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContractTypes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnContractTypes.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnContractTypes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnContractTypes.IconSize = 25;
            this.btnContractTypes.Location = new System.Drawing.Point(903, 36);
            this.btnContractTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnContractTypes.Name = "btnContractTypes";
            this.btnContractTypes.Rotation = 0D;
            this.btnContractTypes.Size = new System.Drawing.Size(185, 32);
            this.btnContractTypes.TabIndex = 25;
            this.btnContractTypes.Text = "View Contract Types";
            this.btnContractTypes.UseVisualStyleBackColor = false;
            this.btnContractTypes.Click += new System.EventHandler(this.btnContractTypes_Click);
            // 
            // lblActiveContracts
            // 
            this.lblActiveContracts.AutoSize = true;
            this.lblActiveContracts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.lblActiveContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveContracts.Location = new System.Drawing.Point(522, 36);
            this.lblActiveContracts.Name = "lblActiveContracts";
            this.lblActiveContracts.Size = new System.Drawing.Size(155, 25);
            this.lblActiveContracts.TabIndex = 29;
            this.lblActiveContracts.Text = "Active Contracts";
            this.lblActiveContracts.Click += new System.EventHandler(this.lblActiveContracts_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btnAddContractType);
            this.panel2.Controls.Add(this.btnUpdateContract);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1088, 72);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(107, 439);
            this.panel2.TabIndex = 1;
            // 
            // btnAddContractType
            // 
            this.btnAddContractType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddContractType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAddContractType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContractType.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddContractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddContractType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddContractType.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAddContractType.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddContractType.IconSize = 25;
            this.btnAddContractType.Location = new System.Drawing.Point(3, 15);
            this.btnAddContractType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddContractType.Name = "btnAddContractType";
            this.btnAddContractType.Rotation = 0D;
            this.btnAddContractType.Size = new System.Drawing.Size(104, 75);
            this.btnAddContractType.TabIndex = 26;
            this.btnAddContractType.Text = "Add Contract Type";
            this.btnAddContractType.UseVisualStyleBackColor = false;
            this.btnAddContractType.Visible = false;
            // 
            // btnUpdateContract
            // 
            this.btnUpdateContract.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnUpdateContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateContract.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdateContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateContract.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUpdateContract.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdateContract.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUpdateContract.IconSize = 25;
            this.btnUpdateContract.Location = new System.Drawing.Point(3, 94);
            this.btnUpdateContract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateContract.Name = "btnUpdateContract";
            this.btnUpdateContract.Rotation = 0D;
            this.btnUpdateContract.Size = new System.Drawing.Size(104, 62);
            this.btnUpdateContract.TabIndex = 23;
            this.btnUpdateContract.Text = "Upgrade /Change";
            this.btnUpdateContract.UseVisualStyleBackColor = false;
            this.btnUpdateContract.Click += new System.EventHandler(this.btnUpdateContract_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.btnAddOrder);
            this.panel3.Controls.Add(this.btnUp);
            this.panel3.Controls.Add(this.btnDown);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(112, 439);
            this.panel3.TabIndex = 2;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAddOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddOrder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddOrder.IconChar = FontAwesome.Sharp.IconChar.FileDownload;
            this.btnAddOrder.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddOrder.IconSize = 40;
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddOrder.Location = new System.Drawing.Point(0, 324);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Rotation = 0D;
            this.btnAddOrder.Size = new System.Drawing.Size(112, 115);
            this.btnAddOrder.TabIndex = 15;
            this.btnAddOrder.Text = "Add Contract";
            this.btnAddOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUp.IconSize = 25;
            this.btnUp.Location = new System.Drawing.Point(80, 94);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Rotation = 0D;
            this.btnUp.Size = new System.Drawing.Size(29, 49);
            this.btnUp.TabIndex = 4;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnDown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDown.IconSize = 25;
            this.btnDown.Location = new System.Drawing.Point(80, 147);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Rotation = 0D;
            this.btnDown.Size = new System.Drawing.Size(29, 49);
            this.btnDown.TabIndex = 3;
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // dgvContracts
            // 
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(118, 78);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.RowTemplate.Height = 24;
            this.dgvContracts.Size = new System.Drawing.Size(943, 333);
            this.dgvContracts.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Contract Type";
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
            this.btnSearch.Location = new System.Drawing.Point(489, 35);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Rotation = 0D;
            this.btnSearch.Size = new System.Drawing.Size(137, 46);
            this.btnSearch.TabIndex = 17;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(326, 49);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(137, 22);
            this.txtSearch.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.btnSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(112, 394);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(976, 117);
            this.panel4.TabIndex = 19;
            // 
            // FormContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1195, 511);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvContracts);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormContracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.FormContracts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblActiveContracts;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private FontAwesome.Sharp.IconButton btnUpdateContract;
        private FontAwesome.Sharp.IconButton btnAddOrder;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnServiceLevels;
        private FontAwesome.Sharp.IconButton btnContractTypes;
        private FontAwesome.Sharp.IconButton btnAddContractType;
    }
}