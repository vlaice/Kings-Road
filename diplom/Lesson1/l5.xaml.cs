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
    /// Логика взаимодействия для l5.xaml
    /// </summary>
    public partial class l5 : Page
    {
        public int A;
        public l5()
        {

            InitializeComponent();
        }

        private void one3_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"\diplom\diplom\MP3\554-1-7-1619538253.wav");
            player.Play();
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l4());
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {


            if (r1.IsChecked == true)
            {

                MessageBox.Show("Молодец, правильно!!!");
                str.Page1.exp += 20;
                ClassPage.Class1.Pagew.Navigate(new Lesson1.l6());
            }
            else 
            {
                MessageBox.Show("Ты допустил ошибку!!!");
            }
            
            
        }

        private void r1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void one3_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
