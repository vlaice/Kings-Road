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
    /// Логика взаимодействия для l5.xaml
    /// </summary>
    public partial class l5 : Page
    {
        public l5()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            str.Page1.exp += 20;
            Class1.Pagew.Navigate(new lesson2.l6());
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            Class1.Pagew.Navigate(new lesson2.l4());
        }
    }
}
