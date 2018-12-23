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
    /// Логика взаимодействия для Warehousecontrol.xaml
    /// </summary>
    public partial class Warehousecontrol : UserControl
    {
        WarehouseRepository instance = WarehouseRepository.GetInstance();
        public Warehousecontrol()
        {
            InitializeComponent();

            lvWarehouse.ItemsSource = instance.GetAll();
        }

        private void tvProduct_Expanded(object sender, RoutedEventArgs e)
        {

            foreach (GridViewColumn c in ((GridView)lvWarehouse.View).Columns)
            {
                if (double.IsNaN(c.Width))
                {
                    c.Width = c.ActualWidth;
                }
                c.Width = double.NaN;
            }
        }

        private void TextBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            (sender as TextBox).IsReadOnly = false;
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            (sender as TextBox).IsReadOnly = true;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            instance.Create(new Warehouse { Product = new Product() });
            lvWarehouse.ItemsSource = instance.GetAll();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                instance.Delete((lvWarehouse.SelectedItem as Warehouse).Id);
                lvWarehouse.ItemsSource = instance.GetAll();
            
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("Select item to delete", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            instance.Update(lvWarehouse.SelectedItem as Warehouse);
            lvWarehouse.ItemsSource = instance.GetAll();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            
                var foundProducts = instance.GetAll().Where(p => p.Product.Name.ToLower().Contains(tbSearch.Text.ToLower())).ToList();
                lvWarehouse.ItemsSource = foundProducts;
            
        }

        private void tbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbSearch.Text == "")
                lvWarehouse.ItemsSource = instance.GetAll();
        }
    }
}
