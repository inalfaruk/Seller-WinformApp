using Bussiness.Abstract;
using Bussiness.Constants.DependencyResolvers.Autofac;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class ShortcutForm : Form
    {
        public ShortcutForm()
        {
            InitializeComponent();
        }

        private void ShortcutForm_Load(object sender, EventArgs e)
        {
            GetProducts();
            GetProductShortcuts();
        }

        private void GetProductShortcuts()
        {
            gridShortcutList.DataSource = InstanceFactory.GetInstance<IProductShortcutService>().GetAllDetails().Data;
            gridShortcutList.Columns[0].Visible = false;
            gridShortcutList.Columns[1].Visible = false;
        }

        private void GetProducts()
        {
            gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAll().Data;
            gridProductList.Columns[0].Visible = false;
            gridProductList.Columns[1].Visible = false;
        }

        private void btnAddShortcut_Click(object sender, EventArgs e)
        {
            if (gridProductList.SelectedRows.Count>0)
            {
                ProductShortcut shortcut = new ProductShortcut();
                shortcut.ProductId = Convert.ToInt32(gridProductList.SelectedRows[0].Cells["ProductId"].Value);
                InstanceFactory.GetInstance<IProductShortcutService>().Add(shortcut);
                GetProductShortcuts();
            }
            
        }

        private void gridProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridShortcutList.SelectedRows.Count > 0)
            {
                ProductShortcut shortcut = new ProductShortcut();                           
                shortcut.ProductShortcutId = Convert.ToInt32(gridShortcutList.SelectedRows[0].Cells["ProductShortcutId"].Value);
                InstanceFactory.GetInstance<IProductShortcutService>().Delete(shortcut);
                GetProductShortcuts();
            }
        }
    }
}
