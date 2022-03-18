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

namespace diplom.lesson2
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

        private void one_Click(object sender, RoutedEventArgs e)
        {
            
            ClassPage.Class1.Pagew.Navigate(new lesson2.l3());
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            if (r3.IsChecked == true)
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
            ClassPage.Class1.Pagew.Navigate(new lesson2.l1());
        }
    }
}
