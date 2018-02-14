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
using Excel = Microsoft.Office.Interop.Excel;
using SharpArchives.ViewModels;

namespace SharpArchives
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string theText;
        public MainWindow()
        {
            InitializeComponent();
        }

        void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            TextBox objTextBox = (TextBox)sender;
            theText = objTextBox.Text;
        }

        private void Advanced_Search_Check(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (theText != null)
            {
                DataContext = new ResultsViewModel();
                MessageBox.Show(theText);
            }
            else
                MessageBox.Show("Pole nie może być puste!");


        }


        //public void Button_Click(object sender, RoutedEventArgs e)
        //{

        //    Excel.Application xlApp = new Excel.Application();
        //    Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\excel_file\2017_opis_dokumentów_cyfrowych.xls");
        //    Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //    Excel.Range xlRange = xlWorksheet.UsedRange;


        //    int rowCount = xlRange.Rows.Count;
        //    int colCount = xlRange.Columns.Count;

        //    MessageBox.Show(rowCount.ToString());
        //    string archivesPath = "C:\\archiwum";
        //    string readmePath = @"C:\archiwum\Czytaj_to.txt";
        //    string[] readme = {"INSTRUKCJA DO PROGRAMU... Napisac.. ", "1", "2"};

        //    if (!File.Exists(readmePath))
        //      File.Create(readmePath);

        //    File.WriteAllLines(readmePath, readme);

        //    if (!Directory.Exists(archivesPath))
        //      Directory.CreateDirectory(archivesPath);
        //}
    }
}
