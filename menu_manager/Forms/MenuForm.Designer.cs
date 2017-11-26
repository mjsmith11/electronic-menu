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
            this.pnlList = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.gvMenuItems = new System.Windows.Forms.DataGridView();
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
            this.pnlCreateButtons = new System.Windows.Forms.Panel();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.btnCreateSave = new System.Windows.Forms.Button();
            this.pnlDeleteButtons = new System.Windows.Forms.Panel();
            this.lblConfirmDelete = new System.Windows.Forms.Label();
            this.btnDeleteNo = new System.Windows.Forms.Button();
            this.btnDeleteYes = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlUpdateButtons = new System.Windows.Forms.Panel();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdateSave = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).BeginInit();
            this.pnlItemDetail.SuspendLayout();
            this.pnlCreateButtons.SuspendLayout();
            this.pnlDeleteButtons.SuspendLayout();
            this.pnlUpdateButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnUpdate);
            this.pnlList.Controls.Add(this.btnDelete);
            this.pnlList.Controls.Add(this.btnCreate);
            this.pnlList.Controls.Add(this.gvMenuItems);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1257, 878);
            this.pnlList.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(695, 824);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 42);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(431, 824);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 42);
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
            this.gvMenuItems.Location = new System.Drawing.Point(0, 3);
            this.gvMenuItems.MultiSelect = false;
            this.gvMenuItems.Name = "gvMenuItems";
            this.gvMenuItems.ReadOnly = true;
            this.gvMenuItems.RowTemplate.Height = 28;
            this.gvMenuItems.Size = new System.Drawing.Size(1250, 805);
            this.gvMenuItems.TabIndex = 0;
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
            this.pnlItemDetail.Location = new System.Drawing.Point(12, 12);
            this.pnlItemDetail.Name = "pnlItemDetail";
            this.pnlItemDetail.Size = new System.Drawing.Size(421, 299);
            this.pnlItemDetail.TabIndex = 2;
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(33, 260);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(73, 20);
            this.lblSpecialty.TabIndex = 14;
            this.lblSpecialty.Text = "Specialty";
            // 
            // cbxSpecialty
            // 
            this.cbxSpecialty.AutoSize = true;
            this.cbxSpecialty.Location = new System.Drawing.Point(113, 260);
            this.cbxSpecialty.Name = "cbxSpecialty";
            this.cbxSpecialty.Size = new System.Drawing.Size(22, 21);
            this.cbxSpecialty.TabIndex = 13;
            this.cbxSpecialty.UseVisualStyleBackColor = true;
            // 
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(34, 233);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(72, 20);
            this.lblAvailable.TabIndex = 12;
            this.lblAvailable.Text = "Available";
            // 
            // cbxAvailable
            // 
            this.cbxAvailable.AutoSize = true;
            this.cbxAvailable.Location = new System.Drawing.Point(113, 233);
            this.cbxAvailable.Name = "cbxAvailable";
            this.cbxAvailable.Size = new System.Drawing.Size(22, 21);
            this.cbxAvailable.TabIndex = 11;
            this.cbxAvailable.UseVisualStyleBackColor = true;
            // 
            // tbxDiscountPrice
            // 
            this.tbxDiscountPrice.Location = new System.Drawing.Point(141, 202);
            this.tbxDiscountPrice.Mask = "$990.00";
            this.tbxDiscountPrice.Name = "tbxDiscountPrice";
            this.tbxDiscountPrice.Size = new System.Drawing.Size(263, 26);
            this.tbxDiscountPrice.TabIndex = 10;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(18, 206);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 20);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discounted";
            // 
            // cbxDiscount
            // 
            this.cbxDiscount.AutoSize = true;
            this.cbxDiscount.Location = new System.Drawing.Point(113, 206);
            this.cbxDiscount.Name = "cbxDiscount";
            this.cbxDiscount.Size = new System.Drawing.Size(22, 21);
            this.cbxDiscount.TabIndex = 8;
            this.cbxDiscount.UseVisualStyleBackColor = true;
            this.cbxDiscount.CheckedChanged += new System.EventHandler(this.cbxDiscount_CheckedChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(63, 170);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Price";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(113, 170);
            this.tbxPrice.Mask = "$990.00";
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(291, 26);
            this.tbxPrice.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // rtbDescription
            // 
            this.rtbDescription.Location = new System.Drawing.Point(113, 68);
            this.rtbDescription.MaxLength = 250;
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(291, 96);
            this.rtbDescription.TabIndex = 4;
            this.rtbDescription.Text = "";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(113, 34);
            this.tbxTitle.MaxLength = 50;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(291, 26);
            this.tbxTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(69, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // ddlCategory
            // 
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Location = new System.Drawing.Point(113, 0);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(291, 28);
            this.ddlCategory.TabIndex = 1;
            this.ddlCategory.TextChanged += new System.EventHandler(this.ddlCategory_TextChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(34, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
            // 
            // pnlCreateButtons
            // 
            this.pnlCreateButtons.Controls.Add(this.btnCreateCancel);
            this.pnlCreateButtons.Controls.Add(this.btnCreateSave);
            this.pnlCreateButtons.Location = new System.Drawing.Point(12, 311);
            this.pnlCreateButtons.Name = "pnlCreateButtons";
            this.pnlCreateButtons.Size = new System.Drawing.Size(419, 100);
            this.pnlCreateButtons.TabIndex = 2;
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Location = new System.Drawing.Point(214, 33);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCreateCancel.TabIndex = 1;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // btnCreateSave
            // 
            this.btnCreateSave.Location = new System.Drawing.Point(105, 33);
            this.btnCreateSave.Name = "btnCreateSave";
            this.btnCreateSave.Size = new System.Drawing.Size(103, 41);
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
            this.pnlDeleteButtons.Location = new System.Drawing.Point(13, 307);
            this.pnlDeleteButtons.Name = "pnlDeleteButtons";
            this.pnlDeleteButtons.Size = new System.Drawing.Size(419, 156);
            this.pnlDeleteButtons.TabIndex = 3;
            // 
            // lblConfirmDelete
            // 
            this.lblConfirmDelete.AutoSize = true;
            this.lblConfirmDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmDelete.Location = new System.Drawing.Point(80, 13);
            this.lblConfirmDelete.Name = "lblConfirmDelete";
            this.lblConfirmDelete.Size = new System.Drawing.Size(251, 50);
            this.lblConfirmDelete.TabIndex = 2;
            this.lblConfirmDelete.Text = "Are you sure you want to\r\ndelete this menu item?";
            this.lblConfirmDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDeleteNo
            // 
            this.btnDeleteNo.Location = new System.Drawing.Point(213, 84);
            this.btnDeleteNo.Name = "btnDeleteNo";
            this.btnDeleteNo.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteNo.TabIndex = 1;
            this.btnDeleteNo.Text = "No";
            this.btnDeleteNo.UseVisualStyleBackColor = true;
            this.btnDeleteNo.Click += new System.EventHandler(this.btnDeleteNo_Click);
            // 
            // btnDeleteYes
            // 
            this.btnDeleteYes.Location = new System.Drawing.Point(104, 84);
            this.btnDeleteYes.Name = "btnDeleteYes";
            this.btnDeleteYes.Size = new System.Drawing.Size(103, 41);
            this.btnDeleteYes.TabIndex = 0;
            this.btnDeleteYes.Text = "Yes";
            this.btnDeleteYes.UseVisualStyleBackColor = true;
            this.btnDeleteYes.Click += new System.EventHandler(this.btnDeleteYes_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(563, 824);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 42);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlUpdateButtons
            // 
            this.pnlUpdateButtons.Controls.Add(this.btnUpdateCancel);
            this.pnlUpdateButtons.Controls.Add(this.btnUpdateSave);
            this.pnlUpdateButtons.Location = new System.Drawing.Point(12, 313);
            this.pnlUpdateButtons.Name = "pnlUpdateButtons";
            this.pnlUpdateButtons.Size = new System.Drawing.Size(419, 100);
            this.pnlUpdateButtons.TabIndex = 4;
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.Location = new System.Drawing.Point(214, 31);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateCancel.TabIndex = 1;
            this.btnUpdateCancel.Text = "Cancel";
            this.btnUpdateCancel.UseVisualStyleBackColor = true;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdateSave
            // 
            this.btnUpdateSave.Location = new System.Drawing.Point(105, 31);
            this.btnUpdateSave.Name = "btnUpdateSave";
            this.btnUpdateSave.Size = new System.Drawing.Size(103, 41);
            this.btnUpdateSave.TabIndex = 0;
            this.btnUpdateSave.Text = "Save";
            this.btnUpdateSave.UseVisualStyleBackColor = true;
            this.btnUpdateSave.Click += new System.EventHandler(this.btnUpdateSave_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 902);
            this.Controls.Add(this.pnlItemDetail);
            this.Controls.Add(this.pnlDeleteButtons);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlUpdateButtons);
            this.Controls.Add(this.pnlCreateButtons);
            this.Name = "MenuForm";
            this.Text = "Menu Manager";
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).EndInit();
            this.pnlItemDetail.ResumeLayout(false);
            this.pnlItemDetail.PerformLayout();
            this.pnlCreateButtons.ResumeLayout(false);
            this.pnlDeleteButtons.ResumeLayout(false);
            this.pnlDeleteButtons.PerformLayout();
            this.pnlUpdateButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gvMenuItems;
        private System.Windows.Forms.Button btnCreate;
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
        private System.Windows.Forms.Panel pnlCreateButtons;
        private System.Windows.Forms.Button btnCreateCancel;
        private System.Windows.Forms.Button btnCreateSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDeleteButtons;
        private System.Windows.Forms.Label lblConfirmDelete;
        private System.Windows.Forms.Button btnDeleteNo;
        private System.Windows.Forms.Button btnDeleteYes;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlUpdateButtons;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdateSave;
    }
}