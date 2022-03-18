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
    /// Логика взаимодействия для l3.xaml
    /// </summary>
    public partial class l3 : Page
    {
        public l3()
        {
            InitializeComponent();
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l2());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson4.l4());
            str.Page1.exp += 20;
        }
    }
}
