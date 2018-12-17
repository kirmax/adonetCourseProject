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
        public List<Purchase> Purchases { get; set; } = new List<Purchase>();
        public MainWindow(Employee employee)
        {

            InitializeComponent();
            DatabaseContext ctx = new DatabaseContext();

            var employees = instance.GetAll();
            EmployeePositionAccess(employees.Where(e => e.Id == employee.Id).FirstOrDefault().Position.Name);
            Purchases = ctx.Purchases.ToList();

            lvPurchases.ItemsSource = Purchases;

           
            
            




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

        private void tvProduct_Expanded(object sender, RoutedEventArgs e)
        {
                      ((GridView)lvPurchases.View).Columns.Where(h => h.Header.Equals("Поставщик")).First().Width = 160;
            
        }
    }


}
