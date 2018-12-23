using Microsoft.Win32;
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

            
            lvEmployee.ItemsSource = instance.GetAll();

            
            


        }

        private void BtnEdit_ClickToSubmit(object sender, RoutedEventArgs e)
        {


            instance.Update(lvEmployee.SelectedItem as Employee);
            lvEmployee.ItemsSource = instance.GetAll();

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

            instance.Create(new Employee { Position = new Position(), Birthdate = DateTime.Now });
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

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseContext ctx = new DatabaseContext())
            {
                var foundEmployees = instance.GetAll().Where(em => em.FirstName.ToLower().Contains(tbSearch.Text.ToLower()) || em.MiddleName.ToLower().Contains(tbSearch.Text.ToLower()) || em.LastName.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
                lvEmployee.ItemsSource = foundEmployees;
            }
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbSearch.Text == "")
                lvEmployee.ItemsSource = instance.GetAll();
        }

        private void lvEmployee_Loaded(object sender, RoutedEventArgs e)
        {
           var firstcolumn = ((GridView)lvEmployee.View).Columns[0];
            
        }

        private void Button_Loaded(object sender, RoutedEventArgs e)
        {
            var Photo = sender as Button;
            if (Photo.Content == null)
                Photo.Content = @"\images\photobtn.png";

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            if (lvEmployee.SelectedItem != null)
            {
                (lvEmployee.SelectedItem as Employee).Photo = Employee.GetImageBytes(fd.FileName);
            }
        }
    }
}
