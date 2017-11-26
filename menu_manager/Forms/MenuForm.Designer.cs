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
            this.gvMenuItems = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlItemDetail = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.ddlCategory = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxPrice = new System.Windows.Forms.MaskedTextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.cbxDiscount = new System.Windows.Forms.CheckBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.tbxDiscountPrice = new System.Windows.Forms.MaskedTextBox();
            this.cbxAvailable = new System.Windows.Forms.CheckBox();
            this.lblAvailable = new System.Windows.Forms.Label();
            this.cbxSpecialty = new System.Windows.Forms.CheckBox();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.pnlCreateButtons = new System.Windows.Forms.Panel();
            this.btnCreateSave = new System.Windows.Forms.Button();
            this.btnCreateCancel = new System.Windows.Forms.Button();
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).BeginInit();
            this.pnlItemDetail.SuspendLayout();
            this.pnlCreateButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.btnCreate);
            this.pnlList.Controls.Add(this.gvMenuItems);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1257, 878);
            this.pnlList.TabIndex = 0;
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
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(327, 824);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 42);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "New";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
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
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(34, 3);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(73, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Category";
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
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(69, 37);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(113, 34);
            this.tbxTitle.MaxLength = 50;
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(291, 26);
            this.tbxTitle.TabIndex = 3;
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
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(18, 68);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(89, 20);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // tbxPrice
            // 
            this.tbxPrice.Location = new System.Drawing.Point(113, 170);
            this.tbxPrice.Mask = "$990.00";
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(291, 26);
            this.tbxPrice.TabIndex = 6;
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
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(18, 206);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(90, 20);
            this.lblDiscount.TabIndex = 9;
            this.lblDiscount.Text = "Discounted";
            // 
            // tbxDiscountPrice
            // 
            this.tbxDiscountPrice.Location = new System.Drawing.Point(141, 202);
            this.tbxDiscountPrice.Mask = "$990.00";
            this.tbxDiscountPrice.Name = "tbxDiscountPrice";
            this.tbxDiscountPrice.Size = new System.Drawing.Size(263, 26);
            this.tbxDiscountPrice.TabIndex = 10;
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
            // lblAvailable
            // 
            this.lblAvailable.AutoSize = true;
            this.lblAvailable.Location = new System.Drawing.Point(34, 233);
            this.lblAvailable.Name = "lblAvailable";
            this.lblAvailable.Size = new System.Drawing.Size(72, 20);
            this.lblAvailable.TabIndex = 12;
            this.lblAvailable.Text = "Available";
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
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(33, 260);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(73, 20);
            this.lblSpecialty.TabIndex = 14;
            this.lblSpecialty.Text = "Specialty";
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
            // btnCreateSave
            // 
            this.btnCreateSave.Location = new System.Drawing.Point(83, 33);
            this.btnCreateSave.Name = "btnCreateSave";
            this.btnCreateSave.Size = new System.Drawing.Size(103, 41);
            this.btnCreateSave.TabIndex = 0;
            this.btnCreateSave.Text = "Save";
            this.btnCreateSave.UseVisualStyleBackColor = true;
            this.btnCreateSave.Click += new System.EventHandler(this.btnCreateSave_Click);
            // 
            // btnCreateCancel
            // 
            this.btnCreateCancel.Location = new System.Drawing.Point(229, 33);
            this.btnCreateCancel.Name = "btnCreateCancel";
            this.btnCreateCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCreateCancel.TabIndex = 1;
            this.btnCreateCancel.Text = "Cancel";
            this.btnCreateCancel.UseVisualStyleBackColor = true;
            this.btnCreateCancel.Click += new System.EventHandler(this.btnCreateCancel_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 902);
            this.Controls.Add(this.pnlCreateButtons);
            this.Controls.Add(this.pnlItemDetail);
            this.Controls.Add(this.pnlList);
            this.Name = "MenuForm";
            this.Text = "Menu Manager";
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).EndInit();
            this.pnlItemDetail.ResumeLayout(false);
            this.pnlItemDetail.PerformLayout();
            this.pnlCreateButtons.ResumeLayout(false);
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
    }
}