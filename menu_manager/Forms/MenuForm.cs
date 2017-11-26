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
        public MenuForm(NetFrameworkMenuContext context)
        {
            InitializeComponent();
            _context = context;
            setupListColumns();
            loadMenuData();

        }

        private void loadMenuData()
        {
            List<data_models.Models.MenuItem> menuItems = MenuItemController.GetItemsSortByCategory(_context);
            gvMenuItems.DataSource = menuItems;;
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

    }
}
