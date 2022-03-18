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

namespace diplom.Lesson4
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
            if (r2.IsChecked == true)
            {

                MessageBox.Show("Молодец, правильно!!!");
                str.Page1.exp += 20;
            }
            else
            {
                MessageBox.Show("Ты допустил ошибку!!!");
            }

        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l1());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l3());
        }
    }
}
