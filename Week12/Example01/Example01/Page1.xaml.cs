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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }
        List<Category> list = new List<Category>(); 
        private void BtnView_Click(object sender, RoutedEventArgs e)
        {
            if(lbDemo.SelectedItem == null)
            {
                return;
            }
            else
            {
                int id = list[lbDemo.SelectedIndex].CategoryID;
                Page2 page2 = new Page2(id);
                this.NavigationService.Navigate(page2);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            northwinddb2Entities entities = new northwinddb2Entities();
            var query = (from x in entities.Categories
                            select new
                            {
                                CategoryName = x.CategoryName,
                                CategoryID = x.CategoryID
                            }).ToList();
            foreach(var x in query)
            {
                lbDemo.Items.Add(x.CategoryName);
                list.Add(item: new Category() {
                    CategoryName = x.CategoryName,
                    CategoryID = x.CategoryID
                });
            }
        }
    }
}
