using Bussiness.Abstract;
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
using System.Transactions;
using System.Windows.Forms;

namespace WinformUI
{
    public partial class SaleForm : Form
    {
        decimal total;
        decimal rowtotal;
        string paymentType;
        int x, y;
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

            GenerateShortcuts();
        }

        private void GenerateShortcuts()
        {
            x = 0;
            y = 0;

            foreach (var item in InstanceFactory.GetInstance<IProductShortcutService>().GetAllDetails().Data)
            {


                Button btn = new Button();

                btn.Width = 120;
                btn.Height = 120;

                btn.Location = new Point(x, y);
                btn.Name = item.Barcode.ToString();
                if (File.Exists(Application.StartupPath.ToString() + @"\images\" + item.Barcode + ".jpg"))
                {
                    btn.BackgroundImage = Image.FromFile(Application.StartupPath.ToString() + @"\images\" + item.Barcode + ".jpg");
                    btn.BackgroundImageLayout = ImageLayout.Stretch;
                }

                btn.Text = item.ProductName.ToString();


                panelShortcuts.Controls.Add(btn);
                btn.Click += new System.EventHandler(btn_Click);
                
                //buton boyutları :)
                x = x + 125;

                if (x > 300)
                {
                    x = 0;
                    y = 125 + y;
                }

            }
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtBarcode.Text = btn.Name;
            txtBarcode.Focus();
            SendKeys.Send("{ENTER}");
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

        private void btnCash_Click(object sender, EventArgs e)
        {
           

            paymentType = (sender as Button).Text;
            MessageBox.Show(paymentType);
            Sell();

        }

        private void Sell()
        {
            using (TransactionScope scope = new TransactionScope())
            {

                try
                {


                    Order order = new Order
                    {

                        PaymentType = paymentType,
                        //  OrderDate = DateTime.Now.ToLocalTime(),
                        Status = false,
                        Description = txtDescription.Text,
                        Total = total

                    };
                    InstanceFactory.GetInstance<IOrderService>().Add(order);


                    OrderDetail orderDetail = new OrderDetail();

                    foreach (var item in orderDetailList)
                    {
                        product = InstanceFactory.GetInstance<IProductService>().GetById(item.ProductId).Data;

                        orderDetail.OrderDetailId = item.OrderDetailId;
                        orderDetail.ProductId = item.ProductId;
                        orderDetail.Quantity = item.Quantity;
                        orderDetail.UnitPrice = item.UnitPrice;
                        orderDetail.OrderId = order.OrderId;

                        InstanceFactory.GetInstance<IOrderDetailService>().Add(orderDetail);



                        product.Quantity -= item.Quantity;


                        InstanceFactory.GetInstance<IProductService>().Update(product);

                    }
                    scope.Complete();
                    orderDetailList.Clear();
                    gridSales.DataSource = orderDetailList;
                    lblTotal.Text = "0 ₺";
                    txtBarcode.Text = "";
                }

                catch
                {
                    scope.Dispose();

                }

            }
        }





        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtBarcode.Text != "")
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

                    orderDetail.Quantity = Convert.ToDecimal(txtQuantity.Text);
                    if (checkStockAdd.Checked)
                        orderDetail.UnitPrice = product.PurchasePrice;
                     else
                    orderDetail.UnitPrice = product.SalePrice;
                   
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
                txtBarcode.Text = "";
            }

        }



        private void btnStockAdd_Click(object sender, EventArgs e)
        {
            if (checkStockAdd.Checked)
            {
                foreach (var item in orderDetailList)
                {
                    product = InstanceFactory.GetInstance<IProductService>().GetById(item.ProductId).Data;
                    product.Quantity += item.Quantity;
                    InstanceFactory.GetInstance<IProductService>().Update(product);
                }
                orderDetailList.Clear();
                txtBarcode.Text = "";
                gridSales.DataSource = orderDetailList;



            }




            InstanceFactory.GetInstance<IProductService>().Update(product);
        }

        private void checkAddStock_CheckedChanged(object sender, EventArgs e)
        {
            if (checkStockAdd.Checked)
            {
                btnStockAdd.Visible = true;
                total = 0;
                lblTotal.Text = "";
                orderDetailList.Clear();
                gridSales.DataSource = orderDetailList;

            }
            else btnStockAdd.Visible = false;
            total = 0;
            lblTotal.Text = "";
            orderDetailList.Clear();
            gridSales.DataSource = orderDetailList;

        }
    }
}
