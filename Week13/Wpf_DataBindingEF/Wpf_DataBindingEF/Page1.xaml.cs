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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        Person person;

        public Page1()
        {
            InitializeComponent();
            person = new Person
            (
                "Hello",
                20
            );
            this.DataContext = person;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(person.ToString());
        }

        private void BtSwitch_Click(object sender, RoutedEventArgs e)
        {
            var page2 = new Page2();
            this.NavigationService.Navigate(page2);
        }
    }
}
