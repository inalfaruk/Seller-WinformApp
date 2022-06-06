using Bussiness.Abstract;
using Bussiness.Concrete;
using Bussiness.Constants.DependencyResolvers.Autofac;
using DataAccess.Concrete.EntityFramework;
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
    public partial class DefinitionsForm : Form
    {
        public DefinitionsForm()
        {
            InitializeComponent();
           
        }

        string Definitions="Unit;";
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DefinitionsForm_Load(object sender, EventArgs e)
        {
            GetAllUnit();
            Definitions = "Unit";
        }

        private void GetAllUnit()
        {

         
            //gridDefinitions.col
            gridDefinitions.DataSource = InstanceFactory.GetInstance<IUnitService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Birim";


        }

        private void GetAllCategory()
        {
            gridDefinitions.DataSource = InstanceFactory.GetInstance<ICategoryService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Kategori";
        }

        private void GetAllBrand()
        {
            gridDefinitions.DataSource = InstanceFactory.GetInstance<IBrandService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Marka";
        }

        private void btnUnit_Click(object sender, EventArgs e)
        {
            Definitions = "Unit";
            lblDefinition.Text = "Birim";
            
            GetAllUnit();
        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            Definitions = "Brand";
            lblDefinition.Text = "Marka";
            GetAllBrand();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Definitions = "Category";
            lblDefinition.Text = "Kategori";
            GetAllCategory();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Definitions == "Category")
            {
                Category category = new Category();
                category.CategoryName = txtDefinition.Text;
                InstanceFactory.GetInstance<ICategoryService>().Add(category);
                GetAllCategory();
            }
            else if (Definitions == "Brand")
            {
                Brand brand = new Brand();
                brand.BrandName = txtDefinition.Text;
                InstanceFactory.GetInstance<IBrandService>().Add(brand);
                GetAllBrand();
            }
            else if (Definitions == "Unit")
            {
                Unit unit = new Unit();
                unit.UnitName = txtDefinition.Text;
                InstanceFactory.GetInstance<IUnitService>().Add(unit);
                GetAllUnit();
            }
            else
                MessageBox.Show("Sorun Oluştu!");
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            if (Definitions == "Category")
            {
                Category category = new Category();
                category.CategoryName = txtDefinition.Text;
             gridDefinitions.DataSource= InstanceFactory.GetInstance<ICategoryService>().GetAllByFilter(txtDefinition.Text).Data;

             
            }
            else if (Definitions == "Brand")
            {
                Brand brand = new Brand();
                brand.BrandName = txtDefinition.Text;
            
                gridDefinitions.DataSource = InstanceFactory.GetInstance<IBrandService>().GetAllByFilter(txtDefinition.Text).Data;
             
            }
            else if (Definitions == "Unit")
            {
                Unit unit = new Unit();
                unit.UnitName = txtDefinition.Text;
                gridDefinitions.DataSource = InstanceFactory.GetInstance<IUnitService>().GetAllByFilter(txtDefinition.Text).Data;
               
            }
            else
                MessageBox.Show("Sorun Oluştu!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
