using diplom.ClassPage;
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
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"diplom\diplom\MP3\15782105855e119519ec419.wav");
            player.Play();
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

        private void one_Click(object sender, RoutedEventArgs e)
        {
            
            Class1.Pagew.Navigate(new lesson2.l5());
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            Class1.Pagew.Navigate(new lesson2.l3());
        }
    }
}
