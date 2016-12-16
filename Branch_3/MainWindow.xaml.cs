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
                int kol = 0;
                for (index = 1; index <= itemCount; index++)
                {
                    number = 1 + rnd1.Next(30);
                    myAll.Add(number);
                    listBox.Items.Add(number);
                }
                int[] mas = myAll.ToArray<int>();
                for (int i = 1; i <= mas.Length - 1; i++)
                {
                    if (mas[i] < mas[0] && mas[i] > mas[itemCount - 1])
                        kol++;

                }
                label.Content = "Количество элементов, меньше\n" + mas[0] + " и больше " + mas[itemCount - 1] + " равно " + kol;

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
