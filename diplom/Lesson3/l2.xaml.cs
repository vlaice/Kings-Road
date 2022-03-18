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

namespace diplom.Lesson3
{
    /// <summary>
    /// Логика взаимодействия для l2.xaml
    /// </summary>
    public partial class l2 : Page
    {
        public l2()
        {
            InitializeComponent();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            if (Box1.Text == "I am" || Box1.Text == "i am")
            {
                Box1.Background = Brushes.LightGreen;
            }
            else
            {
                Box1.Background = Brushes.Red;
            }
            if (Box1.Text == "I am" || Box1.Text == "i am")
            {

                MessageBox.Show("Молодец, правильно!!!");
                str.Page1.exp += 20;
            }
            else
            {
                MessageBox.Show("Ты допустил ошибку, попробуй еще раз!!!");
            }
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson3.l1());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {

        }

        private void one_Click_1(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson3.l3());
        }
    }
}
