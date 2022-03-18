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

namespace diplom.Lesson1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            if (Box1.Text == "Hello" || Box1.Text == "hello")
            {
                Box1.Background = Brushes.LightGreen;
            }
            else
            {
                Box1.Background = Brushes.Red;
            }         
            if (Box1.Text == "Hello" || Box1.Text == "hello")
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
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l1());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l3());
        }
    }
}
