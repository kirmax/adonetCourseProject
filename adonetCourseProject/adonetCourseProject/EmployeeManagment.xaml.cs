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

namespace adonetCourseProject
{
    /// <summary>
    /// Логика взаимодействия для EmployeeManagment.xaml
    /// </summary>
    public partial class EmployeeManagment : UserControl
    {

        EmployeeRepository instance = EmployeeRepository.GetInstance();
        public EmployeeManagment()
        {
            InitializeComponent();

            var employees = instance.GetAll();
            lvEmployee.ItemsSource = employees;


        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            if(lvEmployee.SelectedIndex != -1)
            { 
            instance.Delete(lvEmployee.SelectedIndex + 1);
            lvEmployee.ItemsSource = instance.GetAll();
            }
            else
            {
                MessageBox.Show("Error", "Select employee to delete");
            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            instance.Create(new Employee());
            lvEmployee.ItemsSource = instance.GetAll();

        }
    }
}
