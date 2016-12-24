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
using System.Collections;
using System.IO;
using Microsoft.Win32;


namespace Branch_3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml проверка 1
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //Отобразить массив виде гистораммы

            ArrayList myAL = new ArrayList();
            int sum = 0; //кол - во элементов меньших, чем 21
            int index;
            int itemcount = Convert.ToInt32(textBox.Text);
            Random rn = new Random();
            int number, nn1 = 10;
            listBox.Items.Clear();
            listBox.Items.Add("массив");
            ArrayList myAl2 = new ArrayList();
            for (index = 1; index <= itemcount; index++)
            {
                myAl2.Add(nn1);
                number = -100 + rn.Next(200);
                myAL.Add(number);
                listBox.Items.Add(number);

            }

            Branch_3.Form1 f1 = new Branch_3.Form1();
            int[] masive = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            
            f1.ShowDialog();

        }
        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.F1)
            {
                Branch_3.AboutBox1 F = new Branch_3.AboutBox1();
                F.ShowDialog();
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemcount = Convert.ToInt32(textBox.Text);
            Random rn = new Random();
            int number;
            listBox.Items.Clear();
            for (index = 1; index <= itemcount; index++)
            {
                number = -100 + rn.Next(200);
                myAL.Add(number);
                listBox.Items.Add(number);

            }
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog mydialog = new SaveFileDialog();
            mydialog.Filter = "Текст(*.TXT)|*.TXT" + "|Все файлы (*.*)|*.* ";
            if (mydialog.ShowDialog() == true)
            {
                string filename = mydialog.FileName;
                // StreamWriter file = new StreamWriter(filename,false)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(filename, false))
                    foreach (object inside in listBox.Items)
                    {
                        file.WriteLine(inside);
                    }
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            ArrayList myAL = new ArrayList();
            int index;
            int itemcount = Convert.ToInt32(textBox.Text);
            Random rn = new Random();
            int number;
            listBox.Items.Clear();
            listBox.Items.Add("Исходный массив");
            for (index = 1; index <= itemcount; index++)
            {
                number = -100 + rn.Next(200);
                myAL.Add(number);
                listBox.Items.Add(number);
            }
            myAL.Sort();
            listBox.Items.Add("Отсортированный массив");
            foreach (int elem in myAL)
            {
                listBox.Items.Add(elem);
            }
        }



        /*  private void Window_KeyUp(object sender, KeyEventArgs e)
          {
              if( e.KeyCode == Keys.F1 )
              {
                  //show abouts
              }
          }*/
    }
}
