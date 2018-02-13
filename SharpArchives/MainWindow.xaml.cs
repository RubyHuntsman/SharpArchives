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
using System.IO;

namespace SharpArchives
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string archivesPath = "C:\\archiwum";
            string readmePath = @"C:\archiwum\Czytaj_to.txt";
            string[] readme = {"INSTRUKCJA DO PROGRAMU... Napisac.. ", "1", "2"};

            if (!File.Exists(readmePath))
              File.Create(readmePath);
            
            File.WriteAllLines(readmePath, readme);

            if (!Directory.Exists(archivesPath))
              Directory.CreateDirectory(archivesPath);
        }
    }
}
