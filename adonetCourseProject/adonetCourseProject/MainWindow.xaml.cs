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

        public List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
        public MainWindow(Employee employee)
        {

            InitializeComponent();
            DatabaseContext ctx = new DatabaseContext();
            //EmployeeRepository instance = EmployeeRepository.GetInstance();
            //var employees = instance.GetAll();
            //EmployeePositionAccess(employees.Where(e => e.Id == employee.Id).FirstOrDefault().Position.Name);
            //Warehouses = ctx.Warehouse.ToList();

            // lvShipment.ItemsSource = Warehouses;







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

        /* private void tvProduct_Expanded(object sender, RoutedEventArgs e)
         {

             foreach (GridViewColumn c in ((GridView)lvShipment.View).Columns)
             {
                 if (double.IsNaN(c.Width))
                 {
                     c.Width = c.ActualWidth;
                 }
                 c.Width = double.NaN;
             }
         }

         private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
         {
             Shipment currentItem = lvShipment.SelectedItem as Shipment;
             if ((sender as TextBox).Text != String.Empty && currentItem != null)
             {
                 currentItem.Price = currentItem.Product.Price * currentItem.Quantity;
                 (((GridView)lvShipment.View).Columns[1].CellTemplate.LoadContent() as TextBox).Text = currentItem.Price.ToString();
             }

         }*/
    


    }
}
