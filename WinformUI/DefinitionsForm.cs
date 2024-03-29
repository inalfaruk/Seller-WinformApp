﻿using Bussiness.Abstract;
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
using Color = Entities.Concrete.Color;

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
            gridDefinitions.Columns[1].Width = 244;


        }


        private void GetAllColor()
        {


            gridDefinitions.DataSource = InstanceFactory.GetInstance<IColorService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Renk";
            gridDefinitions.Columns[1].Width = 244;


        }

        private void GetAllCategory()
        {
            gridDefinitions.DataSource = InstanceFactory.GetInstance<ICategoryService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Kategori";
            gridDefinitions.Columns[1].Width = 244;
        }

        private void GetAllBrand()
        {
            gridDefinitions.DataSource = InstanceFactory.GetInstance<IBrandService>().GetAll().Data;
            gridDefinitions.Columns[0].Visible = false;
            gridDefinitions.Columns[1].HeaderText = "Marka";
            gridDefinitions.Columns[1].Width = 244;
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

        private void btnRenk_Click(object sender, EventArgs e)
        {
            Definitions = "Color";
            lblDefinition.Text = "Renk";
            GetAllColor();

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
            else if (Definitions == "Color")
            {
                Color color = new Color();
                color.ColorName = txtDefinition.Text;
                InstanceFactory.GetInstance<IColorService>().Add(color);
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

            else if (Definitions == "Color")
            {
                Entities.Concrete.Color color = new Entities.Concrete.Color();
                color.ColorName = txtDefinition.Text;
                gridDefinitions.DataSource = InstanceFactory.GetInstance<IColorService>().GetAllByFilter(txtDefinition.Text).Data;

            }
            else
                MessageBox.Show("Sorun Oluştu!");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridDefinitions.SelectedRows.Count > 0)
            {



                if (Definitions == "Category")
                {
                    Category category = new Category();
                    category.CategoryId = Convert.ToInt32(gridDefinitions.SelectedRows[0].Cells["categoryId"].Value);
                    InstanceFactory.GetInstance<ICategoryService>().Delete(category);
                    GetAllCategory();
                }
                else if (Definitions == "Brand")
                {
                    Brand brand = new Brand();
                    brand.BrandId = Convert.ToInt32(gridDefinitions.SelectedRows[0].Cells["brandId"].Value);
                    InstanceFactory.GetInstance<IBrandService>().Delete(brand);
                    GetAllBrand();
                }
                else if (Definitions == "Unit")
                {
                    Unit unit = new Unit();
                    unit.UnitId = Convert.ToInt32(gridDefinitions.SelectedRows[0].Cells["unitId"].Value);
                    InstanceFactory.GetInstance<IUnitService>().Delete(unit);
                    GetAllUnit();
                }

                else if (Definitions == "Color")
                {
                    Color color = new Color();
                    color.ColorId = Convert.ToInt32(gridDefinitions.SelectedRows[0].Cells["colorId"].Value);
                    InstanceFactory.GetInstance<IColorService>().Delete(color);
                    GetAllColor();
                }
                else
                    MessageBox.Show("Sorun Oluştu!");
                
            }
        }

  
    }
}
