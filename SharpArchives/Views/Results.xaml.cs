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

namespace SharpArchives.Views
{
    /// <summary>
    /// Logika interakcji dla klasy Results.xaml
    /// </summary>
    public partial class Results : UserControl
    {
        public Results()
        {
            InitializeComponent();
        }

        private void Button_Search(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("szukasz czegoś");
        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            var Main = new MainWindow();
            Main.Show();
        }

        private void Button_Advanced_Search(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
