using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQExercises
{
    public partial class Form1 : Form
    {
        northwinddb2Entities db;
        public Form1()
        {
            InitializeComponent();
            db = new northwinddb2Entities();
            dgvOrders.DataSource = db.Orders.ToList<Order>();

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var query = from order in db.Orders
                        where order.CustomerID == tbSearch.Text
                        orderby order.OrderDate ascending
                        select order;
            dgvOrders.DataSource = query.ToList<Order>();
        }

        private void searchQUICK_Click(object sender, EventArgs e)
        {
            var query = from order in db.Orders
                        where order.CustomerID == "QUICK"
                        select new
                        {
                            CustomerID = order.CustomerID,
                            OrderID = order.OrderID,
                            ShippedDate = order.ShippedDate,
                            CompanyName = order.Shipper.CompanyName
                        };
            dgvOrders.DataSource = query.ToList();
                            
        }

        private void btnOrderWithID_Click(object sender, EventArgs e)
        {
            var query = from order in db.Orders
                        join orderDetail in db.Order_Details
                        on order.OrderID equals orderDetail.OrderID
                        where order.OrderID.ToString() == tbSearch.Text
                        select new
                        {
                            OrderID = order.OrderID,
                            CustomerID = order.CustomerID,
                            ProductName = orderDetail.Product.ProductName,
                            UnitPrice = orderDetail.UnitPrice,
                            Quantity = orderDetail.Quantity,
                            Discount = orderDetail.Discount,
                            Total = (float)(orderDetail.UnitPrice) * (float)orderDetail.Quantity * (float)(1f - orderDetail.Discount)
                        };
            dgvOrders.DataSource = query.ToList();                
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            var query = from order in db.Order_Details
                        join orderDetail in db.Order_Details
                        on order.OrderID equals orderDetail.OrderID
                        where order.OrderID.ToString() == tbSearch.Text
                        select new
                        {
                               GTotal = (float)(orderDetail.UnitPrice) * (float)orderDetail.Quantity * (float)(1f - orderDetail.Discount)
                        };
            MessageBox.Show(query.ToList().Sum((i)=> i.GTotal).ToString(), "Sum");
        }
    }
}
