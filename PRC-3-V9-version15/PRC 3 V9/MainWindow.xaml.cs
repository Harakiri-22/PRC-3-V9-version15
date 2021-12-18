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
using Microsoft.Win32;
using DoubleArrayLibrary;
using Lib_9;

namespace PRC_3_V9
{
    // Дана целочисленная матрица размера M × N. Найти номер последней из ее строк, содержащих максимальное количество одинаковых элементов.
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private DoubleArrayLibrary.Array _thisArray = new DoubleArrayLibrary.Array(3, 3);

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            lineNumberOutput.Text = _thisArray.LastLineNumber();
        }

        private void FillArray_Click(object sender, RoutedEventArgs e)
        {
            lineNumberOutput.Clear();
            _thisArray.Fill();
            dataGrid.ItemsSource = _thisArray.ToTableData().DefaultView;
        }

        private void ClearArray_Click(object sender, RoutedEventArgs e)
        {
            _thisArray.Clear();
            lineNumberOutput.Clear();
            dataGrid.ItemsSource = _thisArray.ToTableData().DefaultView;
        }

        private void SaveArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                saveFileDialog.DefaultExt = ".txt";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.Title = "Экспорт массива";

                if (saveFileDialog.ShowDialog() == true)
                {
                    _thisArray.Conservation(saveFileDialog.FileName);
                }
                dataGrid.ItemsSource = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void OpenArray_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";
                openFileDialog.DefaultExt = ".txt";
                openFileDialog.FilterIndex = 1;
                openFileDialog.Title = "Импорт массива";

                if (openFileDialog.ShowDialog() == true)
                {
                    _thisArray.Opening(openFileDialog.FileName);
                }
                dataGrid.ItemsSource = _thisArray.ToTableData().DefaultView;
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Мишин Д.А. ИСП-34", "Разработчик", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
