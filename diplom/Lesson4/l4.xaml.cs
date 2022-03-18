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
    /// Логика взаимодействия для l4.xaml
    /// </summary>
    public partial class l4 : Page
    {
        public l4()
        {
            InitializeComponent();
        }

        private void one3_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"diplom\diplom\MP3\1c8b668074590556f78498426b576fcd.wav");
            player.Play();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            if (r1.IsChecked == true)
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
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l3());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l5());
        }
    }
}
