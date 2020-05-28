using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Wpf_Basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        // inputs are just number :))
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void BtnApply_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(this.tbDescription.Text);
        }

        private void cbFinished_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.tbNote == null)
                return;
            this.tbNote.Text = (string)((ComboBoxItem)(((ComboBox)sender).SelectedValue)).Content;
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            this.cbAssembly.IsChecked = this.cbDrill.IsChecked = this.cbWeld.IsChecked = this.cbPlasma.IsChecked
                = this.cbLaser.IsChecked = this.cbLathe.IsChecked = this.cbPurchase.IsChecked = this.cbRoll.IsChecked
                = this.cbFold.IsChecked  = this.cbSaw.IsChecked = false;
        }

        private void Cb_Checked(object sender, RoutedEventArgs e)
        {
            this.tbLength.Text += ((CheckBox)sender).Content + " ";
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
