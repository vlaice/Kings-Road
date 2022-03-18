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
    /// Логика взаимодействия для l5.xaml
    /// </summary>
    public partial class l5 : Page
    {
        public l5()
        {
            InitializeComponent();
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void one2_Click_1(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson3.l4());
        }

        private void one3_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"diplom\diplom\MP3\15782242585e11ca8264eb1.wav");
            player.Play();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            if (r3.IsChecked == true)
            {

                MessageBox.Show("Молодец, правильно!!!");
                str.Page1.exp += 20;
                ClassPage.Class1.Pagew.Navigate(new Lesson3.l6());
            }
            else
            {
                MessageBox.Show("Ты допустил ошибку!!!");
            }
            
        }
    }
}
