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

        private void BtnEdit_ClickToSubmit(object sender, RoutedEventArgs e)
        {


            instance.Update(lvEmployee.SelectedItem as Employee);

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                instance.Delete((lvEmployee.SelectedItem as Employee).Id);
                lvEmployee.ItemsSource = instance.GetAll();
            
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Select item to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

            instance.Create(new Employee());
            lvEmployee.ItemsSource = instance.GetAll();

        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            (sender as TextBox).IsReadOnly = false;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).IsReadOnly = true;

        }


       

        
    }
}
