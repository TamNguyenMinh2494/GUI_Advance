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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        northwinddb2Entities entities;
        List<Order> orders;
        public Page2()
        {
            InitializeComponent();
            entities = new northwinddb2Entities();
            orders = new List<Order>();
        }

        public Page2(int id, string cname) : this()
        {
            var query = (from o in entities.Orders
                                          where o.ShipVia == id
                                          select new
                                          {
                                              OrderID = o.OrderID,
                                              CustomerID = o.CustomerID
                                          }).ToList();
            this.dataGrid1.ItemsSource = query;
            this.lbShipperName.Content = "Shipper Name: "+ cname;
            foreach(var i in query)
            {
                orders.Add(item: new Order()
                {
                    OrderID = i.OrderID,
                });
            }
            
            
        }
        private void BtViewOrderDetail_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem == null)
            {
                return;
            }
            else
            {
                int id = orders[dataGrid1.SelectedIndex].OrderID;
                Page3 page3 = new Page3(id);
                this.NavigationService.Navigate(page3);
            }
        }
    }
}
