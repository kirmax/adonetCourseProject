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

            // TextBoxesIsReadOnly(true);

            var a = ((GridView)lvEmployee.View).Columns[1].CellTemplate.LoadContent() as TextBox;
            a.IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[2].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            (((GridView)lvEmployee.View).Columns[3].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[4].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[5].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            (((GridView)lvEmployee.View).Columns[6].CellTemplate.LoadContent() as DatePicker).IsHitTestVisible = false;
            (((GridView)lvEmployee.View).Columns[7].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[8].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[9].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[10].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;


        }

        private void BtnEdit_ClickToEdit(object sender, RoutedEventArgs e)
        {

            //TextBoxesIsReadOnly(false);
            (((GridView)lvEmployee.View).Columns[1].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;

            (((GridView)lvEmployee.View).Columns[2].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;

            (((GridView)lvEmployee.View).Columns[3].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;
            (((GridView)lvEmployee.View).Columns[4].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;
            (((GridView)lvEmployee.View).Columns[5].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;

            (((GridView)lvEmployee.View).Columns[6].CellTemplate.LoadContent() as DatePicker).IsHitTestVisible = true;
            (((GridView)lvEmployee.View).Columns[7].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;
            (((GridView)lvEmployee.View).Columns[8].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;
            (((GridView)lvEmployee.View).Columns[9].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;
            (((GridView)lvEmployee.View).Columns[10].CellTemplate.LoadContent() as TextBox).IsReadOnly = false;

             btnEdit.Click += BtnEdit_ClickToSubmit;


        }

        private void BtnEdit_ClickToSubmit(object sender, RoutedEventArgs e)
        {
            

            instance.Update(lvEmployee.SelectedItem as Employee);
            //TextBoxesIsReadOnly(true);
            (((GridView)lvEmployee.View).Columns[1].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            (((GridView)lvEmployee.View).Columns[2].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            (((GridView)lvEmployee.View).Columns[3].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[4].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[5].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            (((GridView)lvEmployee.View).Columns[6].CellTemplate.LoadContent() as DatePicker).IsHitTestVisible = false;
            (((GridView)lvEmployee.View).Columns[7].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[8].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[9].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;
            (((GridView)lvEmployee.View).Columns[10].CellTemplate.LoadContent() as TextBox).IsReadOnly = true;

            btnEdit.Click += BtnEdit_ClickToEdit;

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

        private void TextBoxesIsReadOnly(bool mode)
        {
            (((GridView)lvEmployee.View).Columns[1].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;

            (((GridView)lvEmployee.View).Columns[2].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;

            (((GridView)lvEmployee.View).Columns[3].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            (((GridView)lvEmployee.View).Columns[4].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            (((GridView)lvEmployee.View).Columns[5].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            
            (((GridView)lvEmployee.View).Columns[6].CellTemplate.LoadContent() as DatePicker).IsHitTestVisible = !mode;
            (((GridView)lvEmployee.View).Columns[7].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            (((GridView)lvEmployee.View).Columns[8].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            (((GridView)lvEmployee.View).Columns[9].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
            (((GridView)lvEmployee.View).Columns[10].CellTemplate.LoadContent() as TextBox).IsReadOnly = mode;
        }
    }
}
