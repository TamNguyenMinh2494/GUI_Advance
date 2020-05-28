using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise02
{
    public partial class Form1 : Form
    {
        NorthwindSQLClassesDataContext dataContext;
        public Form1()
        {
            InitializeComponent();
            dataContext = new NorthwindSQLClassesDataContext();
        }

        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void query01ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.DataSource = dataContext.Customers.ToList();
        }

        private void query02ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.DataSource = (
                from customer in dataContext.Customers
                where (customer.CustomerID).Trim().ToString().StartsWith("A")
                select customer
                );
        }

        private void query03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = from customer in dataContext.Customers
                        where customer.City == "London"
                        select customer;
            gridView.DataSource = query.ToList();
            MessageBox.Show(query.Count().ToString(), "Quantity of customer in London", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void query04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gridView.DataSource = (
                from customer in dataContext.Customers
                where customer.City != null
                select new
                {
                    City = customer.City,
                }
                ).Distinct();
        }

        private void query05ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var minContactName = (from customer in dataContext.Customers
                                 select customer.ContactName.Length).Min();
            var maxContactName = (from customer in dataContext.Customers
                                  select customer.ContactName.Length
                                  ).Max();
            var query = from customer in dataContext.Customers
                        where customer.ContactName.Length == minContactName || customer.ContactName.Length == maxContactName
                        select customer;
            gridView.DataSource = query.ToList();
        }

        private void query06ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = from customer in dataContext.Customers
                        group customer by customer.Country into customerGroup
                        select new
                        {
                            Country = customerGroup.Key,
                            Total = (from cust in customerGroup
                                     select cust.Country).Count()
                        };
            gridView.DataSource = query.ToList();
        }

        private void query07ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = from customer in dataContext.Customers
                        group customer by customer.Country into customerGroup
                        select new
                        {
                            Country = customerGroup.Key,
                            NumberOfCountry = customerGroup.Count()
                        };
            var query1 = from q in query
                         where q.NumberOfCountry == (from q1 in query
                                                     select q1.NumberOfCountry).Max()
                         select q;
            gridView.DataSource = query1;
        }

        // ------------ Exercises 03 ------------ //
        private void query01ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView.DataSource = dataContext.Orders.ToList();
        }

        private void query02ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView.DataSource = (from order in dataContext.Orders
                                   where order.CustomerID == "HANAR"
                                   orderby order.OrderDate ascending
                                   select order).ToList<Order>();
        }

        private void query03ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView.DataSource = (from order in dataContext.Orders
                                   where order.CustomerID == "QUICK"
                                   select new
                                   {
                                       CustomerID = order.CustomerID,
                                       OrderID = order.OrderID,
                                       ShippedDate = order.ShippedDate,
                                       CompanyName = order.Shipper.CompanyName
                                   }).ToList();
        }

        private void query04ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView.DataSource = (from order in dataContext.Orders
                                   join orderDetail in dataContext.Order_Details
                                   on order.OrderID equals orderDetail.OrderID
                                   where order.OrderID.ToString() == "10259"
                                   select new
                                   {
                                       OrderID = order.OrderID,
                                       CustomerID = order.CustomerID,
                                       ProductName = orderDetail.Product.ProductName,
                                       UnitPrice = orderDetail.UnitPrice,
                                       Quantity = orderDetail.Quantity,
                                       Discount = orderDetail.Discount,
                                       Total = (float)(orderDetail.UnitPrice) * (float)orderDetail.Quantity * (float)(1f - orderDetail.Discount)
                                   }).ToList();
        }

        private void query05ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var query = from order in dataContext.Orders
                        join orderDetail in dataContext.Order_Details
                        on order.OrderID equals orderDetail.OrderID
                        where order.OrderID.ToString() == "10259"
                        select new
                        {
                            OrderID = order.OrderID,
                            CustomerID = order.CustomerID,
                            ProductName = orderDetail.Product.ProductName,
                            UnitPrice = orderDetail.UnitPrice,
                            Quantity = orderDetail.Quantity,
                            Discount = orderDetail.Discount,
                            Total = ((float)orderDetail.UnitPrice * (float)orderDetail.Quantity * (float)(1f - orderDetail.Discount))
                        };
            gridView.DataSource = query.ToList();
            MessageBox.Show(query.Sum((i) => i.Total).ToString());
        }

        private void query06ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var query = from order in dataContext.Orders
                        group order by order.OrderID into orderGroup
                        select new
                        {
                            OrderID = orderGroup.Key,
                            Total = (from o in orderGroup
                                     join d in dataContext.Order_Details on o.OrderID equals d.OrderID
                                     select (float)d.UnitPrice*(float)d.Quantity*(float)(1f-d.Discount)).Sum()
                        };
            gridView.DataSource = query.ToList();
        }

        private void query07ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gridView.DataSource = dataContext.Orders.Take(5);
        }
    }
}
