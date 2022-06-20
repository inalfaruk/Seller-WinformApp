using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.Constants.DependencyResolvers.Autofac;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace WinformUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        IProductService _productService;

        public MainForm(ProductManager productService)
        {
            _productService = productService;
        }
        int x;
        int y;
        private void Form1_Load(object sender, EventArgs e)
        {

          
                
            //ProductManager productManager = new ProductManager(new EfProductDal());
            // dataGridView1.DataSource = productManager.GetAll().Data;
            
        }

        private void button2_Click(object sender, EventArgs e)
        { 
         
            ProductForm pf = new ProductForm();
            pf.Show();
        }

        private void btnDefinitions_Click(object sender, EventArgs e)
        {
            DefinitionsForm df = new DefinitionsForm();
            df.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SaleForm sf = new SaleForm();
            sf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProductsListForm productsListForm = new ProductsListForm();
            productsListForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnShortcut_Click(object sender, EventArgs e)
        {
            ShortcutForm shortcutForm = new ShortcutForm();
            shortcutForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}