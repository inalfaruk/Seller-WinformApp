using Bussiness.Abstract;
using Bussiness.Concrete;

using Bussiness.Constants.DependencyResolvers.Autofac;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
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
    public partial class ProductForm : Form
    {
      
        public ProductForm()
        {
           
            InitializeComponent();

        }
        OpenFileDialog fd = new OpenFileDialog();
        bool fdControl=false;
        private void ProductForm_Load(object sender, EventArgs e)
        {
            GetProducts();
            FillAllDataSources();
           
            
        }

       
        List<ProductDetailDto> productList = new List<ProductDetailDto>();     
        private void GetProducts()
        {
            //Her zaman veritabanına bağlanıp veriyi çekmekle sistemi yormamak için tanımladığım productListe verilerimi aktardım

            gridProducts.DataSource  = InstanceFactory.GetInstance<IProductService>().GetAllProductDetail().Data;

       

        }
        StockDbContext stockDbContext = new StockDbContext();
        private void FillAllDataSources()
        {
            //aktardığım verileri burada çağırdım 
                
            
          

           

           

            cmbBrand.DataSource = stockDbContext.Brands.ToList();
            
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandId";
           cmbBrand.SelectedIndex = -1;



            cmbCategory.DataSource = stockDbContext.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.SelectedIndex = -1;

            cmbColor.DataSource = stockDbContext.Colors.ToList();
            cmbColor.DisplayMember = "ColorName";
            cmbColor.ValueMember = "ColorId";
            cmbColor.SelectedIndex = -1;

            cmbUnit.DataSource = stockDbContext.Units.ToList();
            cmbUnit.DisplayMember = "UnitName";
            cmbUnit.ValueMember = "UnitId";
            cmbUnit.SelectedIndex = -1;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.StockCode = txtStockCode.Text;
            product.Barcode = txtBarcode.Text;
            product.ProductName = txtProductName.Text;
            product.CategoryId =Convert.ToInt32(cmbCategory.SelectedValue);
            product.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);
            product.BrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            product.ColorId = Convert.ToInt32(cmbColor.SelectedValue);
            product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
            product.SalesPrice = Convert.ToDecimal(txtSalesPrice.Text);
            product.SpecialCode = txtSpecialCode.Text;
            product.SpecialCode2= txtSpecialCode2.Text;
            product.CriticalQuantity = Convert.ToDecimal(txtCriticalQantity.Text);
            product.Vat = Convert.ToDecimal(txtVat.Text);
            product.Discount = Convert.ToDecimal(txtDiscount.Text);
            product.Description = txtDescription.Text;
            
           
            if (fdControl==true)
            {
                product.ImgPath = product.Barcode.ToString();
           
                var fileName = fd.FileName;
                System.IO.File.Copy(fileName, Application.StartupPath.ToString() +@"\images\" +product.Barcode + ".jpg");
             }
 InstanceFactory.GetInstance<IProductService>().Add(product);
            this.ResetText();
            GetProducts();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ProductsListForm pf = new ProductsListForm();
            pf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
        if (fd.ShowDialog() == DialogResult.OK)
        {

            fd.InitialDirectory = Application.StartupPath.ToString();
            fd.Filter = "Images (*.jpg)|*jpg|All files (*.*)|*.*";
            

                fdControl = true;
        } // MessageBox.Show()
        }
    }
}
