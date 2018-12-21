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
    /// Логика взаимодействия для Purchasecontrol.xaml
    /// </summary>
    public partial class Purchasecontrol : UserControl
    {
        public Purchasecontrol()
        {
            InitializeComponent();
        }
        private void tvProduct_Expanded(object sender, RoutedEventArgs e)
        {

            foreach (GridViewColumn c in ((GridView)lvPurchases.View).Columns)
            {
                if (double.IsNaN(c.Width))
                {
                    c.Width = c.ActualWidth;
                }
                c.Width = double.NaN;
            }
        }
    }
    
}
