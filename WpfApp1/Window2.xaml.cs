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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public static int count = 0;

        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (rb1.IsChecked == true)
            {
                count++;
            }

            if (rb5.IsChecked == true)
            {
                count++;
            }

            if (rb10.IsChecked == true)
            {
                count++;
            }
            if (rb13.IsChecked == true)
            {
                count++;
            }
            if (rb19.IsChecked == true)
            {
                count++;
            }
            if (rb23.IsChecked == true)
            {
                count++;
            }
            if (rb27.IsChecked == true)
            {
                count++;
            }
            if (rb30.IsChecked == true)
            {
                count++;
            }
            if (rb34.IsChecked == true)
            {
                count++;
            }
            if (rb39.IsChecked == true)
            {
                count++;
            }
            if (rb42.IsChecked == true)
            {
                count++;
            }
            if (rb47.IsChecked == true)
            {
                count++;
            }
            if (rb49.IsChecked == true)
            {
                count++;
            }
            if (rb53.IsChecked == true)
            {
                count++;
            }
            if (rb59.IsChecked == true)
            {
                count++;
            }
            if (rb63.IsChecked == true)
            {
                count++;
            }
            if (rb65.IsChecked == true)
            {
                count++;
            }
            if (rb69.IsChecked == true)
            {
                count++;
            }
            if (rb76.IsChecked == true)
            {
                count++;
            }
            if (rb79.IsChecked == true)
            {
                count++;
            }
            if (rb82.IsChecked == true)
            {
                count++;
            }
            if (rb85.IsChecked == true)
            {
                count++;
            }
            if (rb90.IsChecked == true)
            {
                count++;
            }
            if (rb95.IsChecked == true)
            {
                count++;
            }
            if (rb97.IsChecked == true)
            {
                count++;
            }

            if (count <= 10)
            {
                MessageBox.Show(string.Format("Тест не пройден." +
                    "  Вы набрали {0} из 25.", Convert.ToString(count)));

                MainWindow Window = new MainWindow();
                Window.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show(string.Format("Тест пройден." +
                    "  Вы набрали {0} из 25.", Convert.ToString(count)));

                MainWindow Window = new MainWindow();
                Window.Show();
                this.Close();
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int index = quiz.SelectedIndex + 1;
            if (index >= quiz.Items.Count)
                index = 0;
            quiz.SelectedIndex = index;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            int index = quiz.SelectedIndex - 1;
            if (index < 0)
                index = quiz.Items.Count - 1;
            quiz.SelectedIndex = index;
        }
    }
}
