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

namespace Example01
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        northwinddb2Entities entities;
        public Page2()
        {
            InitializeComponent();
            entities = new northwinddb2Entities();
        }
        public Page2(int id):this()
        {
            this.dataGrid1.ItemsSource = (from p in entities.Products
                                        where p.CategoryID == id
                                          select new
                                          {
                                              p.Category.CategoryName,
                                              p.ProductName,
                                              p.QuantityPerUnit,
                                              p.UnitPrice
                                          }).ToList();
        }
    }
}
