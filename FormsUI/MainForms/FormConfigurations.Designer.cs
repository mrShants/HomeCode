namespace FormsUI
{
    partial class FormConfigurations
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
            this.btnDown = new FontAwesome.Sharp.IconButton();
            this.btnUp = new FontAwesome.Sharp.IconButton();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIntError = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchConf = new FontAwesome.Sharp.IconButton();
            this.btnAddConf = new FontAwesome.Sharp.IconButton();
            this.txtConfType = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSearchProd = new FontAwesome.Sharp.IconButton();
            this.dgvConfi = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnRemove = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfi)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDown.IconChar = FontAwesome.Sharp.IconChar.ArrowDown;
            this.btnDown.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDown.IconSize = 25;
            this.btnDown.Location = new System.Drawing.Point(101, 501);
            this.btnDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDown.Name = "btnDown";
            this.btnDown.Rotation = 0D;
            this.btnDown.Size = new System.Drawing.Size(29, 49);
            this.btnDown.TabIndex = 20;
            this.btnDown.UseVisualStyleBackColor = false;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUp.IconChar = FontAwesome.Sharp.IconChar.ArrowUp;
            this.btnUp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUp.IconSize = 25;
            this.btnUp.Location = new System.Drawing.Point(101, 446);
            this.btnUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUp.Name = "btnUp";
            this.btnUp.Rotation = 0D;
            this.btnUp.Size = new System.Drawing.Size(29, 49);
            this.btnUp.TabIndex = 19;
            this.btnUp.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(483, 65);
            this.dgvProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(361, 246);
            this.dgvProducts.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.lblIntError);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSearchConf);
            this.panel1.Controls.Add(this.btnAddConf);
            this.panel1.Controls.Add(this.txtConfType);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 328);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 118);
            this.panel1.TabIndex = 24;
            // 
            // lblIntError
            // 
            this.lblIntError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIntError.AutoSize = true;
            this.lblIntError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntError.ForeColor = System.Drawing.Color.Red;
            this.lblIntError.Location = new System.Drawing.Point(614, 85);
            this.lblIntError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIntError.Name = "lblIntError";
            this.lblIntError.Size = new System.Drawing.Size(182, 20);
            this.lblIntError.TabIndex = 23;
            this.lblIntError.Text = "ID should be an integar";
            this.lblIntError.Visible = false;
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(614, 59);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(253, 20);
            this.lblError.TabIndex = 22;
            this.lblError.Text = "Please fill in atleast one property";
            this.lblError.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(458, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ConfiType";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "ID";
            // 
            // btnSearchConf
            // 
            this.btnSearchConf.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSearchConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchConf.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearchConf.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchConf.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearchConf.IconSize = 25;
            this.btnSearchConf.Location = new System.Drawing.Point(382, 59);
            this.btnSearchConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchConf.Name = "btnSearchConf";
            this.btnSearchConf.Rotation = 0D;
            this.btnSearchConf.Size = new System.Drawing.Size(220, 46);
            this.btnSearchConf.TabIndex = 13;
            this.btnSearchConf.Text = "Search Configuration";
            this.btnSearchConf.UseVisualStyleBackColor = false;
            this.btnSearchConf.Click += new System.EventHandler(this.btnSearchConf_Click);
            // 
            // btnAddConf
            // 
            this.btnAddConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAddConf.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddConf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddConf.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddConf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddConf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddConf.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnAddConf.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAddConf.IconSize = 40;
            this.btnAddConf.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddConf.Location = new System.Drawing.Point(0, 0);
            this.btnAddConf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddConf.Name = "btnAddConf";
            this.btnAddConf.Rotation = 0D;
            this.btnAddConf.Size = new System.Drawing.Size(135, 118);
            this.btnAddConf.TabIndex = 14;
            this.btnAddConf.Text = "Add Configuration";
            this.btnAddConf.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnAddConf.UseVisualStyleBackColor = false;
            // 
            // txtConfType
            // 
            this.txtConfType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfType.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtConfType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfType.Location = new System.Drawing.Point(564, 11);
            this.txtConfType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfType.Name = "txtConfType";
            this.txtConfType.Size = new System.Drawing.Size(137, 22);
            this.txtConfType.TabIndex = 8;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtID.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Location = new System.Drawing.Point(290, 11);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(137, 22);
            this.txtID.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnUp);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.btnDown);
            this.panel2.Location = new System.Drawing.Point(0, -334);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 1047);
            this.panel2.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUpdate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(15, 501);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Rotation = 0D;
            this.btnUpdate.Size = new System.Drawing.Size(81, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDelete.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(15, 462);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(81, 33);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel3.Controls.Add(this.txtProdName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnSearchProd);
            this.panel3.Location = new System.Drawing.Point(849, -325);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(145, 1065);
            this.panel3.TabIndex = 26;
            // 
            // txtProdName
            // 
            this.txtProdName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProdName.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtProdName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProdName.Location = new System.Drawing.Point(61, 550);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(83, 22);
            this.txtProdName.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 549);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Name";
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnSearchProd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchProd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSearchProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearchProd.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnSearchProd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnSearchProd.IconSize = 35;
            this.btnSearchProd.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchProd.Location = new System.Drawing.Point(3, 442);
            this.btnSearchProd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Rotation = 0D;
            this.btnSearchProd.Size = new System.Drawing.Size(145, 54);
            this.btnSearchProd.TabIndex = 23;
            this.btnSearchProd.Text = "Search Product";
            this.btnSearchProd.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSearchProd.UseVisualStyleBackColor = false;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // dgvConfi
            // 
            this.dgvConfi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvConfi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConfi.Location = new System.Drawing.Point(141, 65);
            this.dgvConfi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConfi.Name = "dgvConfi";
            this.dgvConfi.RowTemplate.Height = 24;
            this.dgvConfi.Size = new System.Drawing.Size(245, 246);
            this.dgvConfi.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(994, 59);
            this.panel4.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(556, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(195, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Configuration";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.panel5.Controls.Add(this.btnRemove);
            this.panel5.Controls.Add(this.btnAdd);
            this.panel5.Location = new System.Drawing.Point(392, 55);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(91, 268);
            this.panel5.TabIndex = 29;
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRemove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnRemove.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.btnRemove.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnRemove.IconSize = 25;
            this.btnRemove.Location = new System.Drawing.Point(5, 109);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Rotation = 0D;
            this.btnRemove.Size = new System.Drawing.Size(83, 31);
            this.btnRemove.TabIndex = 24;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnAdd.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(185)))), ((int)(((byte)(248)))));
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(5, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Rotation = 0D;
            this.btnAdd.Size = new System.Drawing.Size(83, 31);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormConfigurations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(994, 446);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgvConfi);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormConfigurations";
            this.Text = "Configurations";
            this.Load += new System.EventHandler(this.FormConfigurations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConfi)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnDown;
        private FontAwesome.Sharp.IconButton btnUp;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSearchConf;
        private FontAwesome.Sharp.IconButton btnAddConf;
        private System.Windows.Forms.TextBox txtConfType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnSearchProd;
        private System.Windows.Forms.DataGridView dgvConfi;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnRemove;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblIntError;
    }
}