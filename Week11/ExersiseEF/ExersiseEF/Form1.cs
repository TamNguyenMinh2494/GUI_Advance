using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExersiseEF
{
    public partial class Form1 : Form
    {
        northwindEntities entities;
        public Form1()
        {
            InitializeComponent();
            entities = new northwindEntities();
        }
        // ----------------------------- Sử dụng Orders Table để thao thác ----------------------------------- //
        private void queryExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Sắp xếp giảm dần của CustomerID và tăng dần của Freight
        private void query01_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Orders.OrderByDescending(i => i.CustomerID).ThenBy(i => i.Freight).ToList();
        }

        // Lọc trong danh sách Orders với tên là HUNGO
        private void query02_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Orders.Where(i => i.CustomerID.Equals("HUNGO")).ToList();
        }

        // Đếm trong danh sách các EmployeeID bằng 4
        private void query03_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Orders.Select(
                emp => new
                {
                    NumOfEmployee = entities.Orders.Where(x => x.EmployeeID == 4).Count() 
                }).Distinct().ToList();
        }

        private void query04_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = entities.Order_Details.Select(
                i => new
                {
                    OrderID = entities.Orders.Select(x => x.OrderID),
                    Quantity = entities.Order_Details.Where(x => x.Quantity == entities.Order_Details.Select(j => j.Quantity).Max())
                }).ToList();
        }

        private void query05_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (entities.Orders.OrderByDescending(x => x.CustomerID)
                .ThenBy(x => x.OrderID)
                .GroupBy(x => x.EmployeeID)
                .Select(i => new
                {
                    EmployeeID = i.Key,
                    TotalOfOrder = i.Count()
                })).ToList();
        }

        private void queryInsert_Click(object sender, EventArgs e)
        {

            Order o = new Order
            {
                OrderID = 123,
                CustomerID = "Testing",
                EmployeeID = 3
            };
            entities.Orders.Add(o);
            int result = entities.SaveChanges();
            dataGridView1.DataSource = entities.Orders.Where(i => i.OrderID == 123).ToList();
            MessageBox.Show(result > 0 ? "Saved it successfully!" : "Failed");
            
        }

        private void queryUpdate_Click(object sender, EventArgs e)
        {
            var query = entities.Orders.Where(i => i.OrderID == 10248);

            query.FirstOrDefault().CustomerID = "Moderated";
            int result = entities.SaveChanges();
            MessageBox.Show(result > 0 ? "Saved it successfully!" : "Failed");
            
        }

        private void queryDelete_Click(object sender, EventArgs e)
        {
            var query = entities.Orders.Where(i => i.OrderID == 10248);
            entities.Orders.Remove(query.First());
            int result = entities.SaveChanges();
            MessageBox.Show(result > 0 ? "Saved it successfully!" : "Failed");
        }
    }
}
