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
    /// Логика взаимодействия для l4.xaml
    /// </summary>
    public partial class l4 : Page
    {
        public l4()
        {
            InitializeComponent();
        }

        private void one2_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l3());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            str.Page1.exp += 20;
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l5());
        }
    }
}
