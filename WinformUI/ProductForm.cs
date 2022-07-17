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
            gridProducts.Columns["ProductId"].Visible = false;
            gridProducts.Columns["StockCode"].HeaderText = "Stok Kodu";
            gridProducts.Columns["Barcode"].HeaderText = "Barkod";
            gridProducts.Columns["ProductName"].HeaderText = "Ürün Adı";
            gridProducts.Columns["CategoryId"].Visible = false;
            gridProducts.Columns["CategoryName"].HeaderText = "Kategori";
            gridProducts.Columns["UnitId"].Visible = false;
            gridProducts.Columns["UnitName"].HeaderText = "Birim";
            gridProducts.Columns["BrandId"].Visible = false;
            gridProducts.Columns["BrandName"].HeaderText = "Marka";
            gridProducts.Columns["ColorId"].Visible = false;
            gridProducts.Columns["ColorName"].HeaderText = "Renk";
            gridProducts.Columns["PurchasePrice"].HeaderText = "Alış Fiyatı";
            gridProducts.Columns["SalePrice"].HeaderText = "Satış Fiyatı";
            gridProducts.Columns["SpecialCode"].HeaderText = "Özel Kod";
            gridProducts.Columns["SpecialCode2"].HeaderText = "Özel Kod 2";
            gridProducts.Columns["CriticalQuantity"].HeaderText = "Kritik Stok";
            gridProducts.Columns["Vat"].HeaderText = "Kdv";
            gridProducts.Columns["Discount"].HeaderText = "İskonto";
            gridProducts.Columns["Description"].HeaderText = "Açıklama";
            //gridProducts.Columns["ImgPath"].Visible = false;
            gridProducts.Columns["Active"].Visible = false;
            gridProducts.Columns["Quantity"].HeaderText = "Stok Mik.";



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
        Product product = new Product();
       // bool crud = false; //false = insert , true = update
        private void btnSave_Click(object sender, EventArgs e)
        {

           
            product.StockCode = txtStockCode.Text;
            product.Barcode = txtBarcode.Text;
            product.ProductName = txtProductName.Text;
            product.CategoryId =Convert.ToInt32(cmbCategory.SelectedValue);
            product.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);
            product.BrandId = Convert.ToInt32(cmbBrand.SelectedValue);
            product.ColorId = Convert.ToInt32(cmbColor.SelectedValue);
            product.PurchasePrice = Convert.ToDecimal(txtPurchasePrice.Text);
            product.SalePrice = Convert.ToDecimal(txtSalePrice.Text);
            product.SpecialCode = txtSpecialCode.Text;
            product.SpecialCode2= txtSpecialCode2.Text;
            product.CriticalQuantity = Convert.ToDecimal(txtCriticalQantity.Text);
            product.Vat = Convert.ToDecimal(txtVat.Text);
            product.Discount = Convert.ToDecimal(txtDiscount.Text);
            product.Description = txtDescription.Text;
            product.Quantity = Convert.ToDecimal(txtQuantity.Text);
            
           
            if (fdControl==true)
            {
                product.ImgPath = product.Barcode.ToString();
           
                var fileName = fd.FileName;
                System.IO.File.Copy(fileName, Application.StartupPath.ToString() +@"\images\" +product.Barcode + ".jpg",true);
             }
            if (product.ProductId>0)
            { 
                InstanceFactory.GetInstance<IProductService>().Update(product);
               
            }
            else
            {
                InstanceFactory.GetInstance<IProductService>().Add(product);
            }
          
            this.ResetText();
            GetProducts();
            product.ProductId = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
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

        private void gridProducts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (gridProducts.SelectedRows.Count>0)
            {
                lblEditMode.Visible = true;
                product.ProductId= Convert.ToInt32(gridProducts.SelectedRows[0].Cells["ProductId"].Value);

                product.StockCode=gridProducts.SelectedRows[0].Cells["StockCode"].Value.ToString();
                txtStockCode.Text = product.StockCode;

                product.Barcode=gridProducts.SelectedRows[0].Cells["Barcode"].Value.ToString();
                txtBarcode.Text = product.Barcode;

                product.ProductName=gridProducts.SelectedRows[0].Cells["ProductName"].Value.ToString();
                txtProductName.Text = product.ProductName;

                product.CategoryId=Convert.ToInt32(gridProducts.SelectedRows[0].Cells["CategoryId"].Value);
                cmbCategory.SelectedValue = product.CategoryId;
               // gridProducts.SelectedRows[0].Cells["CategoryName"].Value.ToString();
               product.UnitId= Convert.ToInt32(gridProducts.SelectedRows[0].Cells["UnitId"].Value);
                cmbUnit.SelectedValue = product.UnitId;
               // gridProducts.SelectedRows[0].Cells["UnitName"].Value.ToString();
              product.BrandId= Convert.ToInt32(gridProducts.SelectedRows[0].Cells["BrandId"].Value);
                cmbBrand.SelectedValue = product.BrandId;
                //gridProducts.SelectedRows[0].Cells["BrandName"].Value.ToString();
               product.ColorId=Convert.ToInt32(gridProducts.SelectedRows[0].Cells["ColorId"].Value);
                cmbColor.SelectedValue = product.ColorId;
                //gridProducts.SelectedRows[0].Cells["ColorName"].Value.ToString();

               product.PurchasePrice= Convert.ToDecimal(gridProducts.SelectedRows[0].Cells["PurchasePrice"].Value);
                txtPurchasePrice.Text = product.PurchasePrice.ToString();

               product.SalePrice =Convert.ToDecimal(gridProducts.SelectedRows[0].Cells["SalePrice"].Value);
                txtSalePrice.Text = product.SalePrice.ToString();

                product.SpecialCode= gridProducts.SelectedRows[0].Cells["SpecialCode"].Value?.ToString();
                txtSpecialCode.Text = product.SpecialCode;

               product.SpecialCode2= gridProducts.SelectedRows[0].Cells["SpecialCode2"].Value?.ToString();
                txtSpecialCode2.Text = product.SpecialCode2;

              product.CriticalQuantity= Convert.ToDecimal( gridProducts.SelectedRows[0].Cells["CriticalQuantity"].Value);
                txtCriticalQantity.Text = product.CriticalQuantity.ToString();

                product.Vat = Convert.ToDecimal( gridProducts.SelectedRows[0].Cells["Vat"].Value);
                txtVat.Text = product.Vat.ToString();

                product.Discount=Convert.ToDecimal(gridProducts.SelectedRows[0].Cells["Discount"].Value);
                txtDiscount.Text = product.Discount.ToString();

               product.Description= gridProducts.SelectedRows[0].Cells["Description"].Value?.ToString();
                txtDescription.Text = product.Description;

                product.ImgPath= gridProducts.SelectedRows[0].Cells["ImgPath"].Value?.ToString();
                pictureProduct.ImageLocation= (Application.StartupPath.ToString() + @"\images\" + product.Barcode + ".jpg");
               


                product.Active= Convert.ToBoolean(gridProducts.SelectedRows[0].Cells["Active"].Value);



               product.Quantity= Convert.ToDecimal(gridProducts.SelectedRows[0].Cells["Quantity"].Value);
               txtQuantity.Text= product.Quantity.ToString();   
               
            }
        }

        private void lblEditMode_Click(object sender, EventArgs e)
        {
            GetProducts();
            product.ProductId = 0;
            lblEditMode.Visible = false;
        }
    }
}
