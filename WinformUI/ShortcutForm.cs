using Bussiness.Abstract;
using Bussiness.Constants.DependencyResolvers.Autofac;
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
            gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAll().Data;
            gridShortcutList.DataSource = InstanceFactory.GetInstance<IShortcutService>().GetAllDetails().Data;
        }
    }
}
