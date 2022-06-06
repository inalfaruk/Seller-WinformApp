using Bussiness.Abstract;
using Bussiness.Constants.DependencyResolvers.Autofac;
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
    public partial class SaleForm : Form
    {
        decimal total;
        decimal rowtotal;
        public SaleForm()
        {
            InitializeComponent();
        }
        List<OrderDetailDto> orderDetailList = new List<OrderDetailDto>();

        Product product = new Product();

        private void SaleForm_Load(object sender, EventArgs e)
        {
            timer.Start();
            GetOrderDetailList();
        }

        private void GetOrderDetailList()
        {
            // gridSales.Columns.Add("ProductName", "Ürün Adı");

            gridSales.DataSource = orderDetailList.ToList();
            gridSales.Columns[0].Visible = false;  //productid
            gridSales.Columns[1].HeaderText = "Ürün Adı";
            gridSales.Columns[1].Width = 200;
            gridSales.Columns[2].Visible = false; //orderdetailid
            gridSales.Columns[3].HeaderText = "Birim Fiyat";
            gridSales.Columns[3].Width = 95;
            gridSales.Columns[4].HeaderText = "Miktar";
            gridSales.Columns[4].Width = 65;
            gridSales.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridSales.Columns[5].HeaderText = "Birim";
            gridSales.Columns[5].Width = 65;
            gridSales.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridSales.Columns[6].HeaderText = "Toplam";
            gridSales.Columns[6].Width = 75;
            //gridSales.Columns[3].HeaderText = "UnitPriceee";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLocalTime().ToString();
        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (checkChange.Checked == true)
            {
                CashBackForm f = new CashBackForm();
                f.ShowDialog();
            }


            Order order = new Order
            {
                PaymentType = "Nakit",
                //  OrderDate = DateTime.Now.ToLocalTime(),
                Status = false,
                Description = txtDescription.Text,
                Total = total

            };

           
      
            InstanceFactory.GetInstance<IOrderService>().Add(order);


          OrderDetail orderDetail = new OrderDetail();
            foreach (var item in orderDetailList)
            {
                orderDetail.ProductId = item.ProductId;
                orderDetail.Quantity = item.Quantity;
                orderDetail.UnitPrice = item.UnitPrice;
                orderDetail.OrderId = order.OrderId;
                orderDetail.OrderDetailId = 0;
                InstanceFactory.GetInstance<IOrderDetailService>().Add(orderDetail);
            }

            
        }


        private void button27_Click(object sender, EventArgs e)
        {






        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                product = InstanceFactory.GetInstance<IProductService>().GetByBarcode(txtBarcode.Text).Data;
                OrderDetailDto orderDetail = new OrderDetailDto();
                e.Handled = true;
                if ((orderDetailList.Count(o => o.ProductId == product.ProductId)) > 0)
                {

                    var result = orderDetailList.Where(o => o.ProductId == product.ProductId).ToList();
                    result.ForEach(o => o.Total = o.Total + (o.UnitPrice * Convert.ToDecimal(txtQuantity.Text)));
                    result.ForEach(o => o.Quantity = o.Quantity + Convert.ToDecimal(txtQuantity.Text));

                }


                else
                {


                    orderDetail.UnitPrice = product.SalesPrice;
                    orderDetail.Quantity = Convert.ToDecimal(txtQuantity.Text);
                    orderDetail.ProductId = product.ProductId;
                    //  orderDetail.Vat = product.Vat;
                    //   rowtotal = product.SalesPrice * Convert.ToDecimal(txtQuantity.Text);
                    //  total = total + rowtotal;
                    orderDetail.ProductName = product.ProductName;
                    orderDetail.UnitName = InstanceFactory.GetInstance<IUnitService>().GetById(product.UnitId).Data.UnitName;
                    orderDetail.Total = orderDetail.Quantity * orderDetail.UnitPrice;
                    orderDetailList.Add(orderDetail);

                }

                GetOrderDetailList();
                total = orderDetailList.Sum(item => item.Total);
                lblTotal.Text = total.ToString() + " ₺";

            }


        }

        private void SaleForm_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
