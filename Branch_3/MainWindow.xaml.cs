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
            Regex X = new Regex(@"^\d+$");
            if (X.IsMatch(textBox.Text))
            {
                listBox1.Items.Clear();
                List<int> myAll = new List<int>();//Основной список
                List<int> list_2 = new List<int>();//Список выборки
                int index;
                int z = 0;
                int itemCount = Convert.ToInt32(textBox.Text);
                Random rnd1 = new Random();
                int number;
                listBox.Items.Clear();
                for (index = 1; index <= itemCount; index++)
                {
                    number = 1 + rnd1.Next(200);
                    myAll.Add(number);
                    listBox.Items.Add(number);
                }
                int[] mas = myAll.ToArray<int>();

                for (int i = 1; i <= mas.Length - 2; i++)
                {
                    if (mas[i] > mas[i - 1] && mas[i] > mas[i + 1])
                    {
                        z++;
                        list_2.Add(mas[i]);

                    }
                }
                foreach (int i in list_2)
                {

                    listBox1.Items.Add(i);

                }
                label.Content = "Количество элементов, \nбольше своих соседей равно " + Convert.ToString(z);
            }
            else
            {
                MessageBox.Show("Ошибка ввода!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Information);
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
