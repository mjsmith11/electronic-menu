using data_models;
using menu_manager.DBControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_manager.Forms
{
    public partial class CouponForm : Form
    {
        public NetFrameworkMenuContext _context { get; }
        private int? activeID;
        public CouponForm(NetFrameworkMenuContext context)
        {
            InitializeComponent();
            _context = context;
            setupListColumns();
            loadMenuData();
            showMenuList();
        }

        private void showMenuList()
        {
            activeID = null;
            pnlCreateButtons.Hide();
            pnlItemDetail.Hide();
            panelList.Show();
            pnlDeleteButtons.Hide();
            CouponGridView.Show();
        }

        private void loadMenuData()
        {
            List<data_models.Models.Coupon> coupons = CouponControllers.GetItemsSortByCategory(_context);
            CouponGridView.DataSource = coupons;
        }

        private void setupListColumns()
        {
            CouponGridView.ColumnCount = 7;

            CouponGridView.Columns[0].Name = "ID";
            CouponGridView.Columns[0].DataPropertyName = "CouponID";
            CouponGridView.Columns[0].Visible = false;

            CouponGridView.Columns[1].Name = "CouponNumber";
            CouponGridView.Columns[1].DataPropertyName = "CouponNumber";
            CouponGridView.Columns[1].HeaderText = "Coupon Number ";
            CouponGridView.Columns[1].Width = 200;

            CouponGridView.Columns[2].Name = "DiscountPrice";
            CouponGridView.Columns[2].DataPropertyName = "DiscountPrice";
            CouponGridView.Columns[2].DefaultCellStyle.Format = "c";
            CouponGridView.Columns[2].HeaderText = "Discount Price";
            CouponGridView.Columns[2].Width = 100;

            CouponGridView.Columns[3].Name = "StartDate";
            CouponGridView.Columns[3].DataPropertyName = "StartDate";
            CouponGridView.Columns[3].HeaderText = "Start Date";
            CouponGridView.Columns[3].Width = 100;
           
            CouponGridView.Columns[4].Name = "EndDate";
            CouponGridView.Columns[4].DataPropertyName = "EndDate";
            CouponGridView.Columns[4].HeaderText = "End Date";
            CouponGridView.Columns[4].Width = 100;

            CouponGridView.Columns[5].Name = "OrderId";
            CouponGridView.Columns[5].DataPropertyName = "OrderId";
            CouponGridView.Columns[5].Visible = false;

            CouponGridView.Columns[6].DataPropertyName = "Orders";
            CouponGridView.Columns[6].Visible = false;

            DataGridViewCheckBoxColumn c = new DataGridViewCheckBoxColumn();
            c.HeaderText = "Status";
            c.DataPropertyName = "Status";
            c.Name = "Status";
            c.Width = 60;
            CouponGridView.Columns.Add(c);
        }

        private void Creatbutton_Click(object sender, EventArgs e)
        {;
            clearDetails();
            panelList.Show();
            pnlItemDetail.Show();
            pnlCreateButtons.Show();
            pnlDeleteButtons.Hide();
            CouponGridView.Hide();
        }

        private void clearDetails()
        {
            NumbertextBox.Text = "";
            ValueTextBox.Text = "";
            statusCheckBox.Checked = true;
            enableAllDetailsControls();
        }

        private void enableAllDetailsControls()
        {
            NumbertextBox.ReadOnly = false;
            ValueTextBox.ReadOnly = false;
            StartdateTimePicker.Enabled = true;
            EnddateTimePicker.Enabled = true;
            statusCheckBox.Enabled = true;
        }

        private void Createbutton_Click(object sender, EventArgs e)
        {
            String error = validateAllControls();
            if (error == "")
            {
                data_models.Models.Coupon m = new data_models.Models.Coupon();
                updateObjectFromForm(ref m);
                CouponControllers.CreateItem(_context, m);
                loadMenuData();
                showMenuList();

            }
            else
            {
                MessageBox.Show(error, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void updateObjectFromForm(ref data_models.Models.Coupon obj)
        {
            obj.CouponNumber = int.Parse(NumbertextBox.Text);
            obj.DiscountPrice = (decimal)Double.Parse(ValueTextBox.Text.Substring(2));
            obj.StartDate = StartdateTimePicker.Value;
            obj.EndDate = EnddateTimePicker.Value;
            obj.Status = statusCheckBox.Checked;
        }

        private string validateAllControls()
        {
            if (NumbertextBox.Text == "")
            {
                return "Coupon Number cannot be blank.";
            }
            if (ValueTextBox.Text == "")
            {
                return "Please input a dicount price.";
            }
            if (StartdateTimePicker == null)
            {
                return "Please select a Start date for using this Coupon.";
            }
            var currentDate = System.DateTime.Now;
            int result = DateTime.Compare(StartdateTimePicker.Value, currentDate);
            int endDateResult= DateTime.Compare(EnddateTimePicker.Value, StartdateTimePicker.Value);
            if (result < 0) 
            {
                return "Please input a Start date later than today.";
            }
            if (endDateResult < 0)
            {
                return "Please input a End date later than Start date.";
            }
            {

            }
            double price;
            try
            {
                price = Double.Parse(ValueTextBox.Text.Substring(1));
            }
            catch (FormatException)
            {
                return "Price format is not correct.";
            }
            if (price < 0.01)
            {
                return "Price cannot be 0";
            }          
            return "";
        }

        private void Canelbutton_Click(object sender, EventArgs e)
        {
            showMenuList();
        }

        private void NumbertextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void DeteleButton_Click(object sender, EventArgs e)
        {
            clearDetails();
            int index = CouponGridView.SelectedCells[0].RowIndex;
            loadListRowIntoDetails(index);
            disableAllDetailsControls();
            panelList.Show();
            pnlItemDetail.Show();          
            pnlDeleteButtons.Show();
            CouponGridView.Hide();
            pnlCreateButtons.Hide();

        }

        private void loadListRowIntoDetails(int index)
        {
            DataGridViewRow row = CouponGridView.Rows[index];
            activeID = int.Parse(row.Cells[0].Value.ToString());
            data_models.Models.Coupon m = CouponControllers.GetOneById(_context, (int)activeID);
            NumbertextBox.Text = Convert.ToString(m.CouponNumber);
            ValueTextBox.Text = toPaddedString((decimal)m.DiscountPrice);
            StartdateTimePicker.Value = m.StartDate;
            EnddateTimePicker.Value = m.EndDate;
            statusCheckBox.Checked = m.Status;
        }
        private String toPaddedString(decimal d)
        {
            if (d < 10)
            {
                return "  " + d.ToString();
            }
            if (d < 100)
            {
                return " " + d.ToString();
            }
            return d.ToString();
        }

        private void disableAllDetailsControls()
        {
            NumbertextBox.ReadOnly = true;
            ValueTextBox.ReadOnly = true;
            StartdateTimePicker.Enabled = false;
            EnddateTimePicker.Enabled = false;
            statusCheckBox.Enabled = false;
        }

        private void nobutton_Click(object sender, EventArgs e)
        {
            showMenuList();
        }

        private void yesbutton_Click(object sender, EventArgs e)
        {
            CouponControllers.DeleteItemById(_context, (int)activeID);
            loadMenuData();
            showMenuList();
        }
    }
}
