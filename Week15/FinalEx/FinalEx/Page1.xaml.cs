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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        northwinddb2Entities entities;
        List<Shipper> shippers;
        public Page1()
        {
            InitializeComponent();
            entities = new northwinddb2Entities();
            shippers = new List<Shipper>();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query = (from x in entities.Shippers
                         select new
                         {
                             CompanyName = x.CompanyName,
                             ShipperID = x.ShipperID
                         }).ToList();
            foreach (var x in query)
            {
                lbxItems.Items.Add(x.CompanyName);
                shippers.Add(item: new Shipper()
                {
                    CompanyName = x.CompanyName,
                    ShipperID = x.ShipperID
                });
            }
        }

        private void BtViewOrders_Click(object sender, RoutedEventArgs e)
        {
            if (lbxItems.SelectedItem == null)
            {
                return;
            }
            else
            {
                int id = shippers[lbxItems.SelectedIndex].ShipperID;
                string cname = shippers[lbxItems.SelectedIndex].CompanyName;
                Page2 page2 = new Page2(id, cname);
                this.NavigationService.Navigate(page2);
            }
        }
    }
}
