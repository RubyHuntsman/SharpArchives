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
            // ######################################################################################

            // TWORZENIE README I ARCHIWUM
            string archivesPath = "C:\\archiwum";
            string readmePath = @"C:\archiwum\Czytaj_to.txt";
            string[] readme = {"INSTRUKCJA DO PROGRAMU... Napisac.. ", "1", "2"};

            if (!File.Exists(readmePath))
              File.Create(readmePath);

            File.WriteAllLines(readmePath, readme);

            if (!Directory.Exists(archivesPath))
              Directory.CreateDirectory(archivesPath);
            // --KONIEC-- TWORZENIE README I ARCHIWUM
            
            // ######################################################################################
            
            // CZYTANIE EXCEL 
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"C:\archiwum\plik.xls");
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;  
            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;

            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= colCount; j++)
                {
                    //new line
                    //if (j == 1)
                      //  Console.Write("\r\n");

                    //write the value to the console
                    if (xlRange.Cells[i, j] != null && xlRange.Cells[i, j].Value2 != null)
                        MessageBox.Show(xlRange.Cells[i, j].Value2.ToString());

                    //add useful things here!   
                }
            }

            // --KONIEC-- CZYTANIE EXCEL

            // ######################################################################################






            //MessageBox.Show(rowCount.ToString());
            
            /*
            if (theText != null)
            {
                DataContext = new ResultsViewModel();
                MessageBox.Show(theText);
            }
            else
                MessageBox.Show("Pole nie może być puste!");
            */






        }

        private void ListBox_SelectionChanged()
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
