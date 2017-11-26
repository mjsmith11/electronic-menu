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
            this.pnlList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlList
            // 
            this.pnlList.Controls.Add(this.gvMenuItems);
            this.pnlList.Location = new System.Drawing.Point(12, 12);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(1257, 1000);
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
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 1024);
            this.Controls.Add(this.pnlList);
            this.Name = "MenuForm";
            this.Text = "Menu Manager";
            this.pnlList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvMenuItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.DataGridView gvMenuItems;
    }
}