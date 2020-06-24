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

namespace Wpf_DataBindingEF
{
    /// <summary>
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        northwinddb2Entities entities;
        List<Category> listCategories;
        public Page2()
        {
            InitializeComponent();
            entities = new northwinddb2Entities();
            listCategories = new List<Category>();
        }

        public List<Category> ListCategories { get => listCategories; set => listCategories = value; }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            var query = (from x in entities.Categories
                         select new
                         {
                             CategoryName = x.CategoryName,
                             CategoryID = x.CategoryID
                         }).ToList();
            foreach (var x in query)
            {
                cbOptions.Items.Add(x.CategoryName);
                listCategories.Add(item: new Category()
                {
                    CategoryName = x.CategoryName,
                    CategoryID = x.CategoryID
                });
            }
        }

        private void BtAction_Click(object sender, RoutedEventArgs e)
        {
            int id = listCategories[cbOptions.SelectedIndex].CategoryID;
            Console.Write(id);
            this.dataGrid2.ItemsSource = (from p in entities.Products
                                          where p.ProductID == id
                                          select new
                                          {
                                              id,
                                              p.ProductName,
                                              p.QuantityPerUnit,
                                              p.UnitPrice,
                                              p.UnitsInStock,
                                              p.UnitsOnOrder,
                                              p.ReorderLevel
                                          }).ToList();
        }
        private void BtLoad_Click(object sender, RoutedEventArgs e)
        {
            this.dataGrid1.ItemsSource = (from i in entities.Categories
                                          select i
                                          ).ToList();
        }
    }
}
