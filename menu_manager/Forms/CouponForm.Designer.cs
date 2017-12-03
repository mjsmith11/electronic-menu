namespace menu_manager.Forms
{
    partial class CouponForm
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
            this.panelList = new System.Windows.Forms.Panel();
            this.pnlDeleteButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nobutton = new System.Windows.Forms.Button();
            this.yesbutton = new System.Windows.Forms.Button();
            this.pnlCreateButtons = new System.Windows.Forms.Panel();
            this.Canelbutton = new System.Windows.Forms.Button();
            this.Createbutton = new System.Windows.Forms.Button();
            this.pnlItemDetail = new System.Windows.Forms.Panel();
            this.EnddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.statusCheckBox = new System.Windows.Forms.CheckBox();
            this.ValueTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NumbertextBox = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Label();
            this.discount = new System.Windows.Forms.Label();
            this.CouponNumber = new System.Windows.Forms.Label();
            this.CouponGridView = new System.Windows.Forms.DataGridView();
            this.DeteleButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.Creatbutton = new System.Windows.Forms.Button();
            this.Updatepanel = new System.Windows.Forms.Panel();
            this.updatebutton = new System.Windows.Forms.Button();
            this.noUpdatebutton = new System.Windows.Forms.Button();
            this.panelList.SuspendLayout();
            this.pnlDeleteButtons.SuspendLayout();
            this.pnlCreateButtons.SuspendLayout();
            this.pnlItemDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CouponGridView)).BeginInit();
            this.Updatepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.pnlItemDetail);
            this.panelList.Controls.Add(this.pnlDeleteButtons);
            this.panelList.Controls.Add(this.CouponGridView);
            this.panelList.Controls.Add(this.DeteleButton);
            this.panelList.Controls.Add(this.EditButton);
            this.panelList.Controls.Add(this.Creatbutton);
            this.panelList.Controls.Add(this.pnlCreateButtons);
            this.panelList.Controls.Add(this.Updatepanel);
            this.panelList.Location = new System.Drawing.Point(-1, 0);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(593, 505);
            this.panelList.TabIndex = 2;
            // 
            // pnlDeleteButtons
            // 
            this.pnlDeleteButtons.Controls.Add(this.label1);
            this.pnlDeleteButtons.Controls.Add(this.nobutton);
            this.pnlDeleteButtons.Controls.Add(this.yesbutton);
            this.pnlDeleteButtons.Location = new System.Drawing.Point(3, 177);
            this.pnlDeleteButtons.Name = "pnlDeleteButtons";
            this.pnlDeleteButtons.Size = new System.Drawing.Size(313, 100);
            this.pnlDeleteButtons.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(30, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Are you sure delete the Coupon";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nobutton
            // 
            this.nobutton.Location = new System.Drawing.Point(181, 51);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(75, 23);
            this.nobutton.TabIndex = 1;
            this.nobutton.Text = "No";
            this.nobutton.UseVisualStyleBackColor = true;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click);
            // 
            // yesbutton
            // 
            this.yesbutton.Location = new System.Drawing.Point(51, 51);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(75, 23);
            this.yesbutton.TabIndex = 0;
            this.yesbutton.Text = "Yes";
            this.yesbutton.UseVisualStyleBackColor = true;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click);
            // 
            // pnlCreateButtons
            // 
            this.pnlCreateButtons.Controls.Add(this.Canelbutton);
            this.pnlCreateButtons.Controls.Add(this.Createbutton);
            this.pnlCreateButtons.Location = new System.Drawing.Point(3, 177);
            this.pnlCreateButtons.Name = "pnlCreateButtons";
            this.pnlCreateButtons.Size = new System.Drawing.Size(313, 100);
            this.pnlCreateButtons.TabIndex = 10;
            // 
            // Canelbutton
            // 
            this.Canelbutton.Location = new System.Drawing.Point(202, 34);
            this.Canelbutton.Name = "Canelbutton";
            this.Canelbutton.Size = new System.Drawing.Size(75, 23);
            this.Canelbutton.TabIndex = 1;
            this.Canelbutton.Text = "Canel";
            this.Canelbutton.UseVisualStyleBackColor = true;
            this.Canelbutton.Click += new System.EventHandler(this.Canelbutton_Click);
            // 
            // Createbutton
            // 
            this.Createbutton.Location = new System.Drawing.Point(36, 34);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(75, 23);
            this.Createbutton.TabIndex = 0;
            this.Createbutton.Text = "Create";
            this.Createbutton.UseVisualStyleBackColor = true;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // pnlItemDetail
            // 
            this.pnlItemDetail.Controls.Add(this.EnddateTimePicker);
            this.pnlItemDetail.Controls.Add(this.StartdateTimePicker);
            this.pnlItemDetail.Controls.Add(this.statusCheckBox);
            this.pnlItemDetail.Controls.Add(this.ValueTextBox);
            this.pnlItemDetail.Controls.Add(this.NumbertextBox);
            this.pnlItemDetail.Controls.Add(this.status);
            this.pnlItemDetail.Controls.Add(this.end);
            this.pnlItemDetail.Controls.Add(this.start);
            this.pnlItemDetail.Controls.Add(this.discount);
            this.pnlItemDetail.Controls.Add(this.CouponNumber);
            this.pnlItemDetail.Location = new System.Drawing.Point(3, 3);
            this.pnlItemDetail.Name = "pnlItemDetail";
            this.pnlItemDetail.Size = new System.Drawing.Size(313, 179);
            this.pnlItemDetail.TabIndex = 4;
            // 
            // EnddateTimePicker
            // 
            this.EnddateTimePicker.Location = new System.Drawing.Point(115, 103);
            this.EnddateTimePicker.Name = "EnddateTimePicker";
            this.EnddateTimePicker.Size = new System.Drawing.Size(159, 21);
            this.EnddateTimePicker.TabIndex = 11;
            // 
            // StartdateTimePicker
            // 
            this.StartdateTimePicker.Location = new System.Drawing.Point(115, 73);
            this.StartdateTimePicker.Name = "StartdateTimePicker";
            this.StartdateTimePicker.Size = new System.Drawing.Size(159, 21);
            this.StartdateTimePicker.TabIndex = 10;
            // 
            // statusCheckBox
            // 
            this.statusCheckBox.AutoSize = true;
            this.statusCheckBox.Location = new System.Drawing.Point(114, 134);
            this.statusCheckBox.Name = "statusCheckBox";
            this.statusCheckBox.Size = new System.Drawing.Size(180, 16);
            this.statusCheckBox.TabIndex = 9;
            this.statusCheckBox.Text = "(set is valid or in valid)";
            this.statusCheckBox.UseVisualStyleBackColor = true;
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(115, 38);
            this.ValueTextBox.Mask = "$990.00";
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(159, 21);
            this.ValueTextBox.TabIndex = 6;
            // 
            // NumbertextBox
            // 
            this.NumbertextBox.Location = new System.Drawing.Point(114, 9);
            this.NumbertextBox.Name = "NumbertextBox";
            this.NumbertextBox.Size = new System.Drawing.Size(160, 21);
            this.NumbertextBox.TabIndex = 5;
            this.NumbertextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumbertextBox_KeyPress);
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(61, 139);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(47, 12);
            this.status.TabIndex = 4;
            this.status.Text = "Status:";
            // 
            // end
            // 
            this.end.AutoSize = true;
            this.end.Location = new System.Drawing.Point(49, 109);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(59, 12);
            this.end.TabIndex = 3;
            this.end.Text = "End Date:";
            // 
            // start
            // 
            this.start.AutoSize = true;
            this.start.Location = new System.Drawing.Point(37, 79);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(71, 12);
            this.start.TabIndex = 2;
            this.start.Text = "Start Date:";
            // 
            // discount
            // 
            this.discount.AutoSize = true;
            this.discount.Location = new System.Drawing.Point(67, 48);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(41, 12);
            this.discount.TabIndex = 1;
            this.discount.Text = "Value:";
            // 
            // CouponNumber
            // 
            this.CouponNumber.AutoSize = true;
            this.CouponNumber.Location = new System.Drawing.Point(19, 16);
            this.CouponNumber.Name = "CouponNumber";
            this.CouponNumber.Size = new System.Drawing.Size(89, 12);
            this.CouponNumber.TabIndex = 0;
            this.CouponNumber.Text = "Coupon Number:";
            // 
            // CouponGridView
            // 
            this.CouponGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CouponGridView.Location = new System.Drawing.Point(3, 3);
            this.CouponGridView.Name = "CouponGridView";
            this.CouponGridView.RowTemplate.Height = 23;
            this.CouponGridView.Size = new System.Drawing.Size(589, 462);
            this.CouponGridView.TabIndex = 3;
            // 
            // DeteleButton
            // 
            this.DeteleButton.Location = new System.Drawing.Point(399, 471);
            this.DeteleButton.Name = "DeteleButton";
            this.DeteleButton.Size = new System.Drawing.Size(75, 23);
            this.DeteleButton.TabIndex = 2;
            this.DeteleButton.Text = "Delete";
            this.DeteleButton.UseVisualStyleBackColor = true;
            this.DeteleButton.Click += new System.EventHandler(this.DeteleButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(250, 471);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // Creatbutton
            // 
            this.Creatbutton.Location = new System.Drawing.Point(101, 471);
            this.Creatbutton.Name = "Creatbutton";
            this.Creatbutton.Size = new System.Drawing.Size(75, 23);
            this.Creatbutton.TabIndex = 0;
            this.Creatbutton.Text = "New";
            this.Creatbutton.UseVisualStyleBackColor = true;
            this.Creatbutton.Click += new System.EventHandler(this.Creatbutton_Click);
            // 
            // Updatepanel
            // 
            this.Updatepanel.Controls.Add(this.noUpdatebutton);
            this.Updatepanel.Controls.Add(this.updatebutton);
            this.Updatepanel.Location = new System.Drawing.Point(3, 180);
            this.Updatepanel.Name = "Updatepanel";
            this.Updatepanel.Size = new System.Drawing.Size(313, 97);
            this.Updatepanel.TabIndex = 12;
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(51, 36);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(75, 23);
            this.updatebutton.TabIndex = 0;
            this.updatebutton.Text = "Submit";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // noUpdatebutton
            // 
            this.noUpdatebutton.Location = new System.Drawing.Point(181, 36);
            this.noUpdatebutton.Name = "noUpdatebutton";
            this.noUpdatebutton.Size = new System.Drawing.Size(75, 23);
            this.noUpdatebutton.TabIndex = 1;
            this.noUpdatebutton.Text = "Cancel";
            this.noUpdatebutton.UseVisualStyleBackColor = true;
            this.noUpdatebutton.Click += new System.EventHandler(this.noUpdatebutton_Click);
            // 
            // CouponForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 506);
            this.Controls.Add(this.panelList);
            this.Name = "CouponForm";
            this.Text = "CouponForm";
            this.panelList.ResumeLayout(false);
            this.pnlDeleteButtons.ResumeLayout(false);
            this.pnlDeleteButtons.PerformLayout();
            this.pnlCreateButtons.ResumeLayout(false);
            this.pnlItemDetail.ResumeLayout(false);
            this.pnlItemDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CouponGridView)).EndInit();
            this.Updatepanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.Button DeteleButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button Creatbutton;
        private System.Windows.Forms.DataGridView CouponGridView;
        private System.Windows.Forms.Panel pnlItemDetail;
        private System.Windows.Forms.Label CouponNumber;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.Label start;
        private System.Windows.Forms.Label discount;
        private System.Windows.Forms.TextBox NumbertextBox;
        private System.Windows.Forms.MaskedTextBox ValueTextBox;
        private System.Windows.Forms.CheckBox statusCheckBox;
        private System.Windows.Forms.Panel pnlCreateButtons;
        private System.Windows.Forms.Button Canelbutton;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.DateTimePicker EnddateTimePicker;
        private System.Windows.Forms.DateTimePicker StartdateTimePicker;
        private System.Windows.Forms.Panel pnlDeleteButtons;
        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Updatepanel;
        private System.Windows.Forms.Button noUpdatebutton;
        private System.Windows.Forms.Button updatebutton;
    }
}