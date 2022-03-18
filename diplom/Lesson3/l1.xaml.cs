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
    /// Логика взаимодействия для l1.xaml
    /// </summary>
    public partial class l1 : Page
    {
        public l1()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"diplom\diplom\MP3\15785695195e170f2f802f5.wav");
            player.Play();
            str.Page1.exp += 20;
        }

        private void one_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void one_Click_2(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson3.l2());
        }
    }
}
