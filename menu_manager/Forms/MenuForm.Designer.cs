namespace menu_manager.Forms
{
    partial class MenuForm
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
            this.tcTabControl = new System.Windows.Forms.TabControl();
            this.tabMenu = new System.Windows.Forms.TabPage();
            this.pnlCreateButtons = new System.Windows.Forms.Panel();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreateSave = new System.Windows.Forms.Button();
            this.pnlDeleteButtons = new System.Windows.Forms.Panel();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.btnDeleteNo = new System.Windows.Forms.Button();
            this.btnDeleteYes = new System.Windows.Forms.Button();
            this.pnlUpdateButtons = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.pnlItemDetail = new System.Windows.Forms.Panel();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.cbxSpecialty = new System.Windows.Forms.CheckBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.tbxDiscountPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.cbxDiscount = new System.Windows.Forms.CheckBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.coupon = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gvMenuItems = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tcTabControl.SuspendLayout();
            this.tabMenu.SuspendLayout();
            this.pnlCreateButtons.SuspendLayout();
            this.pnlDeleteButtons.SuspendLayout();
            this.pnlUpdateButtons.SuspendLayout();
            this.pnlItemDetail.SuspendLayout();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // tcTabControl
            // 
            this.tcTabControl.Controls.Add(this.tabMenu);
            this.tcTabControl.Controls.Add(this.tabPage2);
            this.tcTabControl.Location = new System.Drawing.Point(13, 13);
            this.tcTabControl.Name = "tcTabControl";
            this.tcTabControl.SelectedIndex = 0;
            this.tcTabControl.Size = new System.Drawing.Size(920, 611);
            this.tcTabControl.TabIndex = 0;
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.pnlCreateButtons);
            this.tabMenu.Controls.Add(this.pnlDeleteButtons);
            this.tabMenu.Controls.Add(this.pnlUpdateButtons);
            this.tabMenu.Controls.Add(this.pnlItemDetail);
            this.tabMenu.Controls.Add(this.pnlList);
            this.tabMenu.Location = new System.Drawing.Point(4, 22);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.Padding = new System.Windows.Forms.Padding(3);
            this.tabMenu.Size = new System.Drawing.Size(912, 585);
            this.tabMenu.TabIndex = 0;
            this.tabMenu.Text = "Menu";
            this.tabMenu.UseVisualStyleBackColor = true;
            // 
            // pnlCreateButtons
            // 
            this.pnlCreateButtons.Controls.Add(this.btnCreateCancel);
            this.pnlCreateButtons.Controls.Add(this.btnCreateSave);
            this.pnlCreateButtons.Location = new System.Drawing.Point(37, 202);
            this.pnlCreateButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCreateButtons.Name = "pnlCreateButtons";
            this.pnlCreateButtons.Size = new System.Drawing.Size(279, 65);
            this.pnlCreateButtons.TabIndex = 6;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Location = new System.Drawing.Point(143, 22);
            this.btnCreateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(69, 27);
            this.btnCreateCancel.TabIndex = 1;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreateSave
            // 
            this.btnCreateSave.Location = new System.Drawing.Point(70, 22);
            this.btnCreateSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSave.Name = "btnCreateSave";
            this.btnCreateSave.Size = new System.Drawing.Size(69, 27);
            this.btnCreateSave.TabIndex = 0;
            this.btnCreateSave.Text = "Save";
            this.btnCreateSave.UseVisualStyleBackColor = true;
            this.btnCreateSave.Click += new System.EventHandler(this.btnCreateSave_Click);
            // 
            // pnlDeleteButtons
            // 
            this.pnlDeleteButtons.Controls.Add(this.lblConfirmDelete);
            this.pnlDeleteButtons.Controls.Add(this.btnDeleteNo);
            this.pnlDeleteButtons.Controls.Add(this.btnDeleteYes);
            this.pnlDeleteButtons.Location = new System.Drawing.Point(38, 198);
            this.pnlDeleteButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDeleteButtons.Name = "pnlDeleteButtons";
            this.pnlDeleteButtons.Size = new System.Drawing.Size(279, 102);
            this.pnlDeleteButtons.TabIndex = 8;
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDelete.Location = new System.Drawing.Point(53, 9);
            this.lblConfirmDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(189, 34);
            this.lblConfirmDelete.TabIndex = 2;
            this.lblConfirmDelete.Text = "Are you sure you want to\r\ndelete this menu item?";
            this.lblConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteNo
            // 
            this.btnDeleteNo.Location = new System.Drawing.Point(142, 54);
            this.btnDeleteNo.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteNo.Name = "btnDeleteNo";
            this.btnDeleteNo.Size = new System.Drawing.Size(69, 27);
            this.btnDeleteNo.TabIndex = 1;
            this.btnDeleteNo.Text = "No";
            this.btnDeleteNo.UseVisualStyleBackColor = true;
            this.btnDeleteNo.Click += new System.EventHandler(this.btnDeleteNo_Click);
            // 
            // btnDeleteYes
            // 
            this.btnDeleteYes.Location = new System.Drawing.Point(69, 54);
            this.btnDeleteYes.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteYes.Name = "btnDeleteYes";
            this.btnDeleteYes.Size = new System.Drawing.Size(69, 27);
            this.btnDeleteYes.TabIndex = 0;
            this.btnDeleteYes.Text = "Yes";
            this.btnDeleteYes.UseVisualStyleBackColor = true;
            this.btnDeleteYes.Click += new System.EventHandler(this.btnDeleteYes_Click);
            // 
            // pnlUpdateButtons
            // 
            this.pnlUpdateButtons.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateButtons.Controls.Add(this.btnUpdateSave);
            this.pnlUpdateButtons.Location = new System.Drawing.Point(37, 203);
            this.pnlUpdateButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUpdateButtons.Name = "pnlUpdateButtons";
            this.pnlUpdateButtons.Size = new System.Drawing.Size(279, 65);
            this.pnlUpdateButtons.TabIndex = 9;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(143, 21);
            this.btnUpdateCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(69, 27);
            this.btnUpdateCancel.TabIndex = 1;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(70, 21);
            this.btnUpdateSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(69, 27);
            this.btnUpdateSave.TabIndex = 0;
            this.btnUpdateSave.Text = "Save";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // pnlItemDetail
            // 
            this.pnlItemDetail.Controls.Add(this.lblSpecialty);
            this.pnlItemDetail.Controls.Add(this.cbxSpecialty);
            this.pnlItemDetail.Controls.Add(this.lblAvailable);
            this.pnlItemDetail.Controls.Add(this.cbxAvailable);
            this.pnlItemDetail.Controls.Add(this.tbxDiscountPrice);
            this.pnlItemDetail.Controls.Add(this.lblDiscount);
            this.pnlItemDetail.Controls.Add(this.cbxDiscount);
            this.pnlItemDetail.Controls.Add(this.lblPrice);
            this.pnlItemDetail.Controls.Add(this.tbxPrice);
            this.pnlItemDetail.Controls.Add(this.lblDescription);
            this.pnlItemDetail.Controls.Add(this.rtbDescription);
            this.pnlItemDetail.Controls.Add(this.tbxTitle);
            this.pnlItemDetail.Controls.Add(this.lblTitle);
            this.pnlItemDetail.Controls.Add(this.ddlCategory);
            this.pnlItemDetail.Controls.Add(this.lblCategory);
            this.pnlItemDetail.Location = new System.Drawing.Point(37, 7);
            this.pnlItemDetail.Margin = new System.Windows.Forms.Padding(2);
            this.pnlItemDetail.Name = "pnlItemDetail";
            this.pnlItemDetail.Size = new System.Drawing.Size(281, 194);
            this.pnlItemDetail.TabIndex = 7;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(22, 169);
            this.lblSpecialty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(50, 13);
            this.lblSpecialty.TabIndex = 14;
            this.lblSpecialty.Text = "Specialty";
            // 
            // cbxSpecialty
            // 
            this.cbxSpecialty.AutoSize = true;
            this.cbxSpecialty.Location = new System.Drawing.Point(75, 169);
            this.cbxSpecialty.Margin = new System.Windows.Forms.Padding(2);
            this.cbxSpecialty.Name = "cbxSpecialty";
            this.cbxSpecialty.Size = new System.Drawing.Size(15, 14);
            this.cbxSpecialty.TabIndex = 13;
            this.cbxSpecialty.UseVisualStyleBackColor = true;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(23, 152);
            this.lblAvailable.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(50, 13);
            this.lblAvailable.TabIndex = 12;
            this.lblAvailable.Text = "Available";
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(75, 152);
            this.cbxAvailable.Margin = new System.Windows.Forms.Padding(2);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(15, 14);
            this.cbxAvailable.TabIndex = 11;
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxDiscountPrice
            // 
            this.tbxDiscountPrice.Location = new System.Drawing.Point(94, 131);
            this.tbxDiscountPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxDiscountPrice.Mask = "$990.00";
            this.tbxDiscountPrice.Name = "tbxDiscountPrice";
            this.tbxDiscountPrice.Size = new System.Drawing.Size(177, 20);
            this.tbxDiscountPrice.TabIndex = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(12, 134);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(61, 13);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discounted";
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.AutoSize = true;
            this.cbxDiscount.Location = new System.Drawing.Point(75, 134);
            this.cbxDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(15, 14);
            this.cbxDiscount.TabIndex = 8;
            this.cbxDiscount.UseVisualStyleBackColor = true;
            this.cbxDiscount.CheckedChanged += new System.EventHandler(this.cbxDiscount_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(42, 111);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(75, 111);
            this.tbxPrice.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPrice.Mask = "$990.00";
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(195, 20);
            this.tbxPrice.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 44);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(75, 44);
            this.rtbDescription.Margin = new System.Windows.Forms.Padding(2);
            this.rtbDescription.MaxLength = 250;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(195, 64);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(75, 22);
            this.tbxTitle.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTitle.MaxLength = 50;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(195, 20);
            this.tbxTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(46, 24);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(75, 0);
            this.ddlCategory.Margin = new System.Windows.Forms.Padding(2);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(195, 21);
            this.ddlCategory.TabIndex = 1;
            this.ddlCategory.TextChanged += new System.EventHandler(this.ddlCategory_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(23, 2);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.coupon);
            this.pnlList.Controls.Add(this.btnUpdate);
            this.pnlList.Controls.Add(this.btnDelete);
            this.pnlList.Controls.Add(this.btnCreate);
            this.pnlList.Controls.Add(this.gvMenuItems);
            this.pnlList.Location = new System.Drawing.Point(37, 7);
            this.pnlList.Margin = new System.Windows.Forms.Padding(2);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(838, 571);
            this.pnlList.TabIndex = 5;
            // 
            // coupon
            // 
            this.coupon.BackColor = System.Drawing.SystemColors.HotTrack;
            this.coupon.Location = new System.Drawing.Point(721, 536);
            this.coupon.Name = "coupon";
            this.coupon.Size = new System.Drawing.Size(111, 25);
            this.coupon.TabIndex = 4;
            this.coupon.Text = "Coupon Manager";
            this.coupon.UseVisualStyleBackColor = false;
            this.coupon.Click += new System.EventHandler(this.coupon_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(375, 535);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Edit";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(463, 535);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 27);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(287, 535);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(84, 27);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // gvMenuItems
            // 
            this.gvMenuItems.AllowUserToAddRows = false;
            this.gvMenuItems.AllowUserToDeleteRows = false;
            this.gvMenuItems.AllowUserToOrderColumns = true;
            this.gvMenuItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMenuItems.Location = new System.Drawing.Point(0, 2);
            this.gvMenuItems.Margin = new System.Windows.Forms.Padding(2);
            this.gvMenuItems.MultiSelect = false;
            this.gvMenuItems.Name = "gvMenuItems";
            this.gvMenuItems.ReadOnly = true;
            this.gvMenuItems.RowTemplate.Height = 28;
            this.gvMenuItems.Size = new System.Drawing.Size(833, 523);
            this.gvMenuItems.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(912, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 636);
            this.Controls.Add(this.tcTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuForm";
            this.Text = "Menu Manager";
            this.tcTabControl.ResumeLayout(false);
            this.tabMenu.ResumeLayout(false);
            this.pnlCreateButtons.ResumeLayout(false);
            this.pnlDeleteButtons.ResumeLayout(false);
            this.pnlDeleteButtons.PerformLayout();
            this.pnlUpdateButtons.ResumeLayout(false);
            this.pnlItemDetail.ResumeLayout(false);
            this.pnlItemDetail.PerformLayout();
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcTabControl;
        private System.Windows.Forms.TabPage tabMenu;
        private System.Windows.Forms.Panel pnlCreateButtons;
        private System.Windows.Forms.Button btnCreateCancel;
        private System.Windows.Forms.Button btnCreateSave;
        private System.Windows.Forms.Panel pnlDeleteButtons;
        private System.Windows.Forms.Label lblConfirmDelete;
        private System.Windows.Forms.Button btnDeleteNo;
        private System.Windows.Forms.Button btnDeleteYes;
        private System.Windows.Forms.Panel pnlUpdateButtons;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSave;
        private System.Windows.Forms.Panel pnlItemDetail;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.CheckBox cbxSpecialty;
        private System.Windows.Forms.Label lblAvailable;
        private System.Windows.Forms.CheckBox cbxAvailable;
        private System.Windows.Forms.MaskedTextBox tbxDiscountPrice;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.CheckBox cbxDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.MaskedTextBox tbxPrice;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox ddlCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Button coupon;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView gvMenuItems;
        private System.Windows.Forms.TabPage tabPage2;
    }
}