﻿using System;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(Employee employee)
        {
            InitializeComponent();
            EmployeePositionAccess(employee.Position.Name);
            ;
        }

        public void EmployeePositionAccess(string position)
        {
            switch (position)
            {
                case "Admin":
                    break;
                case "CEO":
                    break;
                case "Secretary":
                    break;
                default:
                    break;
            }
        }
    }


}
