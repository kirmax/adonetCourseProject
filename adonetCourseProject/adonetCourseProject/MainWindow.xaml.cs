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
        EmployeeRepository instance = EmployeeRepository.GetInstance();
        public MainWindow(Employee employee)
        {
            InitializeComponent();


            var employees = instance.GetAll();
            EmployeePositionAccess(employees.Where(e => e.Id == employee.Id).FirstOrDefault().Position.Name);
            ucEmployeeManagment.lvEmployee.ItemsSource = employees;

            ucEmployeeManagment.btnAdd.Click += BtnAdd_Click;
            ucEmployeeManagment.btnDelete.Click += BtnDelete_Click;
            
            
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            
            instance.Delete(ucEmployeeManagment.lvEmployee.SelectedIndex + 1);
            ucEmployeeManagment.lvEmployee.ItemsSource = instance.GetAll();

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            instance.Create(new Employee());
            ucEmployeeManagment.lvEmployee.ItemsSource = instance.GetAll();

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

       

       
    }


}
