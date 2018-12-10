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
using System.Data.Entity;

namespace adonetCourseProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow(Employee employee)
        {
            
            InitializeComponent();
            EmployeePositionAccess(employee.Position.Name);
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var employees = ctx.Employees.Include(e => e.Position).ToList();
                EmployeePositionAccess(employees.Where(e => e.Id == employee.Id).FirstOrDefault().Position.Name);
                lvEmployee.ItemsSource = employees;
                
                
            }

            lblEmployeeCount.Content = lvEmployee.Items.Count;
        }

        public void EmployeePositionAccess(string position)
        {
            switch (position)
            {
               /* case "Admin":
                    break;*/
                case "CEO":
                    break;
                case "Secretary":
                    break;
                case "HR":
                    break;
                default:
                    break;
            }
        }

        private void lvEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblEmployeeCount.Content = lvEmployee.Items.Count;
        }

        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnEditEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDeleteEmployee_Click(object sender, RoutedEventArgs e)
        {

        }

        private void lvEmployee_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }
    }


}
