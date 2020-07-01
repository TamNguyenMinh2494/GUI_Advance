using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FinalEx
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        northwinddb2Entities entities;
        private float total;
        public Page3()
        {
            InitializeComponent();
            entities = new northwinddb2Entities();
        }
        public Page3(int id) : this()
        {
            var query1 = (from od in entities.Order_Details
                          join p in entities.Products on od.ProductID equals p.ProductID
                          where od.OrderID == id
                          select new
                          {
                              Description = p.ProductName,
                              Price = od.UnitPrice,
                              Quantity = od.Quantity,
                              Amount = (float)(od.UnitPrice * od.Quantity),
                          }).ToList();
            listview1.ItemsSource = query1 ;
            this.lbOrder.Content = "Order: " + id;
            
            foreach(var i in query1)
            {
                total += i.Amount; 
            }
            this.lbTotal.Content = "Total: " + total;
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            for (int i = 0; i < App.Current.Windows.Count; i++)
            {
                App.Current.Windows[i].Close();
            }
        }
    }
}
