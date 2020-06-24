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

namespace Ex01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students, filtered;
        
        public MainWindow()
        {
            InitializeComponent();
            btOK.Style = (Style)Resources["btOK"];
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            students = new List<Student>();
            students.Add(new Student { Name = "Nguyen Van Teo", Age = 29 });
            students.Add(new Student { Name = "Nguyen Van Ti", Age = 12 });
            students.Add(new Student { Name = "Nguyen Thi Tun", Age = 50 });
            students.Add(new Student { Name = "Nguyen Van A", Age = 9 });
            dataGrid1.ItemsSource = students;
        }

        private void TbSearch_KeyUp(object sender, KeyEventArgs e)
        {
            filtered = new List<Student>();
            if (tbSearch.Text.Equals(""))
            {
                filtered.AddRange(students);
            }
            else
            {
                foreach (Student student in students)
                {
                    if (student.Name.ToLower().Contains(tbSearch.Text))
                    {
                        filtered.Add(student);
                    }
                    if (student.Age.ToString().Contains(tbSearch.Text))
                    {
                        filtered.Add(student);
                    }
                }
                
            }
            dataGrid1.ItemsSource = filtered.ToList();
        }
    }
}
