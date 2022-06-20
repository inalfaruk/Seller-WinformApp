using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.Constants.DependencyResolvers.Autofac;
using DataAccess.Concrete.EntityFramework;
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
    public partial class ProductsListForm : Form
    {
        public ProductsListForm()
        {
            InitializeComponent();
          
        }
      
       

       

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            radioStockCode.Checked=true;
          
            gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllProductDetail().Data;
            gridProductList.Columns[0].HeaderText = "ProductId";
            gridProductList.Columns[0].Visible = false;

            gridProductList.Columns[1].HeaderText = "Stok Kodu";
            gridProductList.Columns[2].HeaderText = "Barkod";
            gridProductList.Columns[3].HeaderText = "Ürün Adı";
            gridProductList.Columns[4].HeaderText = "CategoryId";
            gridProductList.Columns[4].Visible = false;

            gridProductList.Columns[5].HeaderText = "Kategori";


            gridProductList.Columns[6].HeaderText = "UnitId";
            gridProductList.Columns[6].Visible = false;

            gridProductList.Columns[7].HeaderText = "Birim";

            gridProductList.Columns[8].HeaderText = "BrandId";
            gridProductList.Columns[8].Visible = false;

            gridProductList.Columns[9].HeaderText = "Marka";

            gridProductList.Columns[10].HeaderText = "ColorId";
            gridProductList.Columns[10].Visible = false;
            gridProductList.Columns[11].HeaderText = "Renk";

            gridProductList.Columns[12].HeaderText = "Alış Fiyatı";
            gridProductList.Columns[13].HeaderText = "Satış Fiyatı";

            gridProductList.Columns[14].HeaderText = "Özel Kod";
            gridProductList.Columns[15].HeaderText = "Özel Kod 2";
            gridProductList.Columns[16].HeaderText = "Kritik Stok";
            gridProductList.Columns[17].HeaderText = "Kdv";
            gridProductList.Columns[18].HeaderText = "İskonto";
            gridProductList.Columns[19].HeaderText = "Açıklama";

             gridProductList.Columns[20].HeaderText = "Resim";

             gridProductList.Columns[21].HeaderText = "Active";
              gridProductList.Columns[21].Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
         
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (txtFilter.Text.Length>2)
            {
                if (radioBarcode.Checked)
                {
                    gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllByBarcode(txtFilter.Text).Data;
                }
                else if (radioBrand.Checked)
                {
                    gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllByBrand(txtFilter.Text).Data;
                }
                else if (radioStockCode.Checked)
                {
                    gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllByStockCode(txtFilter.Text).Data;
                }
                else if (radioStokName.Checked)
                {
                     gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllByProductName(txtFilter.Text).Data;
                }
                else if (radioCategory.Checked)
                {
                    gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllByCategory(txtFilter.Text).Data;
                }
               
            }

            if (txtFilter.Text.Length<1)

            {
                gridProductList.DataSource = InstanceFactory.GetInstance<IProductService>().GetAllProductDetail().Data;
            }
        }
    }
}
