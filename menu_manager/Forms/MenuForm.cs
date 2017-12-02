using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using data_models;
using data_models.Models;
using menu_manager.DBControllers;

namespace menu_manager.Forms
{
    public partial class MenuForm : Form
    {
        public NetFrameworkMenuContext _context { get; }
        private int? activeID;
        public MenuForm(NetFrameworkMenuContext context)
        {
            InitializeComponent();
            _context = context;
            setupListColumns();
            loadMenuData();
            showMenuList();

        }

        private void loadMenuData()
        {
            List<data_models.Models.MenuItem> menuItems = MenuItemController.GetItemsSortByCategory(_context);
            gvMenuItems.DataSource = menuItems;
        }

        private void setupListColumns()
        {
            gvMenuItems.ColumnCount = 7;

            gvMenuItems.Columns[0].Name = "ID";
            gvMenuItems.Columns[0].DataPropertyName = "MenuItemID";
            gvMenuItems.Columns[0].Visible = false;

            gvMenuItems.Columns[1].Name = "Category";
            gvMenuItems.Columns[1].DataPropertyName = "Category";
            gvMenuItems.Columns[1].HeaderText = "Category";
            gvMenuItems.Columns[1].Width = 150;

            gvMenuItems.Columns[2].Name = "Title";
            gvMenuItems.Columns[2].DataPropertyName = "Title";
            gvMenuItems.Columns[2].HeaderText = "Title";
            gvMenuItems.Columns[2].Width = 300;

            gvMenuItems.Columns[3].Name = "Description";
            gvMenuItems.Columns[3].DataPropertyName = "Description";
            gvMenuItems.Columns[3].HeaderText = "Description";
            gvMenuItems.Columns[3].Visible = false;

            gvMenuItems.Columns[4].Name = "Price";
            gvMenuItems.Columns[4].DataPropertyName = "Price";
            gvMenuItems.Columns[4].DefaultCellStyle.Format = "c";
            gvMenuItems.Columns[4].HeaderText = "Regular Price";
            gvMenuItems.Columns[4].Width = 100;

            gvMenuItems.Columns[5].Name = "DiscountPrice";
            gvMenuItems.Columns[5].DataPropertyName = "DiscountPrice";
            gvMenuItems.Columns[5].DefaultCellStyle.Format = "c";
            gvMenuItems.Columns[5].HeaderText = "Discount Price";
            gvMenuItems.Columns[5].Width = 100;

            gvMenuItems.Columns[6].DataPropertyName = "OrderItems";
            gvMenuItems.Columns[6].Visible = false;

            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.HeaderText = "Available";
            c.DataPropertyName = "IsAvailable";
            c.Name = "IsAvailable";
            c.Width = 60;
            gvMenuItems.Columns.Add(c);

            c = new DataGridViewCheckBoxColumn();
            c.HeaderText = "Specialty";
            c.DataPropertyName = "IsSpecialty";
            c.Name = "IsSpecialty";
            c.Width = 60;
            gvMenuItems.Columns.Add(c);



        }


        private void populateCategoriesDropDown()
        {
            List<String> categories = MenuItemController.GetCategories(_context);
            ddlCategory.DataSource = categories;
        }

        private void clearDetails()
        {
            tbxTitle.Text = "";
            rtbDescription.Text = "";
            tbxPrice.Text = "";
            cbxDiscount.Checked = false;
            tbxDiscountPrice.Text = "";
            ddlCategory.Text = "";
            cbxAvailable.Checked = true; //Default to available
            cbxSpecialty.Checked = false;

            tbxDiscountPrice.ReadOnly = true;
            enableAllDetailsControls();
        }

        private void showMenuList()
        {
            activeID = null;
            pnlCreateButtons.Hide();
            pnlDeleteButtons.Hide();
            pnlUpdateButtons.Hide();
            pnlItemDetail.Hide();

            pnlList.Show();
        }

        private void disablePrice()
        {
            tbxPrice.ReadOnly = true;
            tbxPrice.Text = "";
            cbxDiscount.Checked = false;
            cbxDiscount.Enabled = false;
            tbxDiscountPrice.ReadOnly = true;
            tbxPrice.Text = "";
        }

        private void enablePrice()
        {
            tbxPrice.ReadOnly = false;
            if (cbxDiscount.Checked)
                tbxDiscountPrice.ReadOnly = false;
            else
                tbxDiscountPrice.ReadOnly = true;
            cbxDiscount.Enabled = true;
        }

        private string validateAllControls()
        {
            if (ddlCategory.Text == "")
            {
                return "Category cannot be blank.";
            }
            if (tbxTitle.Text == "")
            {
                return "Title cannot be blank.";
            }
            if (ddlCategory.Text != "Sides")
            {
                double price;
                try
                {
                    price = Double.Parse(tbxPrice.Text.Substring(1));
                }
                catch (FormatException)
                {
                    return "Price format is not correct.";
                }
                if (price < 0.01)
                {
                    return "Price cannot be 0";
                }
                if (cbxDiscount.Checked)
                {
                    double discountPrice;
                    try
                    {
                        discountPrice = Double.Parse(tbxDiscountPrice.Text.Substring(1));
                    }
                    catch (FormatException)
                    {
                        return "Discount Price format is not correct.";
                    }
                    if (discountPrice < 0.01)
                    {
                        return "Discount Price cannot be 0";
                    }
                    if (discountPrice >= price)
                    {
                        return "Discount price must be less than the regular price.";
                    }
                }
            }


            return "";
        }

        private void updateObjectFromForm(ref data_models.Models.MenuItem obj)
        {
            obj.Category = ddlCategory.Text;
            obj.Title = tbxTitle.Text;
            obj.Description = rtbDescription.Text;
            obj.Price = (decimal)Double.Parse(tbxPrice.Text.Substring(1));
            if (cbxDiscount.Checked)
            {
                obj.DiscountPrice = (decimal)Double.Parse(tbxDiscountPrice.Text.Substring(1));
            }
            else
            {
                obj.DiscountPrice = null;
            }
            obj.IsAvailable = cbxAvailable.Checked;
            obj.IsSpecialty = cbxSpecialty.Checked;
        }

        private void disableAllDetailsControls()
        {
            ddlCategory.Enabled = false;
            tbxTitle.ReadOnly = true;
            rtbDescription.ReadOnly = true;
            tbxPrice.ReadOnly = true;
            cbxDiscount.Enabled = false;
            tbxDiscountPrice.ReadOnly = true;
            cbxAvailable.Enabled = false;
            cbxSpecialty.Enabled = false;
        }

        private void enableAllDetailsControls()
        {
            ddlCategory.Enabled = true;
            tbxTitle.ReadOnly = false;
            rtbDescription.ReadOnly = false;
            tbxPrice.ReadOnly = false;
            cbxDiscount.Enabled = true;
            tbxDiscountPrice.ReadOnly = false;
            cbxAvailable.Enabled = true;
            cbxSpecialty.Enabled = true;

            // depending on some form values we may actually want some stuff disabled
            cbxDiscount_CheckedChanged(null, null);
            ddlCategory_TextChanged(null, null);
        }

        private void loadListRowIntoDetails(int RowIndex)
        {
            DataGridViewRow row = gvMenuItems.Rows[RowIndex];
            activeID = int.Parse(row.Cells[0].Value.ToString());
            data_models.Models.MenuItem m = MenuItemController.GetOneById(_context,(int)activeID);
            ddlCategory.Text = m.Category;
            tbxTitle.Text = m.Title;
            if (m.Description != null)
                rtbDescription.Text = m.Description;
            if (m.Price != null)
                tbxPrice.Text = toPaddedString((decimal)m.Price);
            if (m.DiscountPrice == null)
            {
                cbxDiscount.Checked = false;
            }
            else
            {
                cbxDiscount.Checked = true;
                tbxDiscountPrice.Text = toPaddedString((decimal)m.DiscountPrice);
            }

            cbxAvailable.Checked = m.IsAvailable;
            cbxSpecialty.Checked = m.IsSpecialty;
        }

        //convert a decimal to string with 3 characters right of the decimal and two right
        private String toPaddedString(decimal d)
        {
            if(d < 10)
            {
                return "  " + d.ToString();
            }
            if(d < 100)
            {
                return " " + d.ToString();
            }
            return d.ToString();
        }

        private void cbxDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxDiscount.Checked)
            {
                tbxDiscountPrice.ReadOnly = false;
            }
            else
            {
                tbxDiscountPrice.ReadOnly = true;
                tbxDiscountPrice.Text = "";
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            populateCategoriesDropDown();
            clearDetails();
            pnlList.Hide();
            pnlItemDetail.Show();
            pnlCreateButtons.Show();
        }

        private void btnCreateCancel_Click(object sender, EventArgs e)
        {
            showMenuList();
        }

        private void ddlCategory_TextChanged(object sender, EventArgs e)
        {
            if(ddlCategory.Text=="Sides")
            {
                disablePrice();
            }
            else
            {
                enablePrice();
            }
        }

        private void btnCreateSave_Click(object sender, EventArgs e)
        {
            String error = validateAllControls();
            if(error == "")
            {
                data_models.Models.MenuItem m = new data_models.Models.MenuItem();
                updateObjectFromForm(ref m);
                MenuItemController.CreateItem(_context, m);
                loadMenuData();
                showMenuList();
                
            }
            else
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearDetails();
            int index = gvMenuItems.SelectedCells[0].RowIndex;
            loadListRowIntoDetails(index);
            disableAllDetailsControls();
            pnlList.Hide();
            pnlItemDetail.Show();
            pnlDeleteButtons.Show();
        }

        private void btnDeleteNo_Click(object sender, EventArgs e)
        {
            showMenuList();
        }

        private void btnDeleteYes_Click(object sender, EventArgs e)
        {
            MenuItemController.DeleteItemById(_context, (int)activeID);
            loadMenuData();
            showMenuList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clearDetails();
            int index = gvMenuItems.SelectedCells[0].RowIndex;
            populateCategoriesDropDown();
            loadListRowIntoDetails(index);
            enableAllDetailsControls();
            pnlList.Hide();
            pnlItemDetail.Show();
            pnlUpdateButtons.Show();
        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            showMenuList();
        }

        private void btnUpdateSave_Click(object sender, EventArgs e)
        {
            String error = validateAllControls();
            if (error == "")
            {
                data_models.Models.MenuItem m = new data_models.Models.MenuItem();
                updateObjectFromForm(ref m);
                MenuItemController.UpdateItemByObject(_context,(int)activeID,m);
                loadMenuData();
                showMenuList();

            }
            else
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void coupon_Click(object sender, EventArgs e)
        {
            CouponForm welcome = new CouponForm();
            welcome.ShowDialog();
        }
    }
}
