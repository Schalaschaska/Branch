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
using System.Text.RegularExpressions;

namespace Branch_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            listBox.Items.Clear();
            Regex X = new Regex(@"^\d+$");
            if (X.IsMatch(textBox.Text))
            {

                List<int> myAll = new List<int>();//Основной список
                int index;
                int itemCount = Convert.ToInt32(textBox.Text);
                Random rnd1 = new Random();
                int number;
                int sum = 0;
                for (index = 1; index <= itemCount; index++)
                {
                    number = 1 + rnd1.Next(30);
                    myAll.Add(number);
                    listBox.Items.Add(number);
                }
                int[] mas = myAll.ToArray<int>();
                for (int i = 0; i <= mas.Length - 1; i++)
                {
                    sum = sum + mas[i];

                }
                if (mas[0] > sum / mas.Length)
                {
                    label.Content = mas[0] + " превосходит среднее значение\nэлементов массива " + sum / mas.Length;
                }
                else
                {
                    label.Content = mas[0] + " не превосходит среднее значение\nэлементов массива" + sum / mas.Length;
                }

            }

            else
            {
                MessageBox.Show("Ошибка ввода!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                AboutBox1 F = new AboutBox1();
                F.ShowDialog();
            }
        }
    }
}
