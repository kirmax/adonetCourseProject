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

        //public List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();
        public MainWindow(Employee employee)
        {

            InitializeComponent();
            // DatabaseContext ctx = new DatabaseContext();
            EmployeeRepository instance = EmployeeRepository.GetInstance();
            //var employees = instance.GetAll();
            EmployeePositionAccess(instance.GetAll().Where(e => e.Id == employee.Id).FirstOrDefault().Position.Name);
            //Warehouses = ctx.Warehouse.ToList();

            // lvShipment.ItemsSource = Warehouses;


            




        }

        public void EmployeePositionAccess(string position)
        {
            switch (position)
            {
                
                case "CEO":
                    lblPurchases.IsEnabled = true;
                    lblEmployees.IsEnabled = true;
                    lblShipments.IsEnabled = true;
                    lblWarehouse.IsEnabled = true;
                    break;
                case "ShipmentsDepartment":
                    lblShipments.IsEnabled = true;
                    break;
                case "HR":
                    lblEmployees.IsEnabled = true;
                    break;
                case "PurchasesDepartment":
                    lblPurchases.IsEnabled = true;
                    break;
                case "WarehouseWorker":
                    lblWarehouse.IsEnabled = true;
                    break;
                default:
                    break;
            }
        }

        private void Label_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var curlbl = sender as Label;
            if (grid.Children.Count > 1) grid.Children.RemoveAt(1);
            switch (curlbl.Content)
            {
                case "Отдел закупок":
                    {
                        Purchasecontrol pc = new Purchasecontrol();
                        grid.Children.Add(pc);
                        break;
                    }
                case "Отдел кадров":
                    {
                        EmployeeManagment em = new EmployeeManagment();
                        grid.Children.Add(em);
                        break;
                    }
                case "Отдел продаж":
                    {
                       Shipmentcontrol sc = new Shipmentcontrol();
                        grid.Children.Add(sc);
                        break;
                    }
                case "Склад":
                    {
                        Warehousecontrol wc = new Warehousecontrol();
                        grid.Children.Add(wc);
                        break;
                    }


                default:
                    break;
            }
        }




    }
}
