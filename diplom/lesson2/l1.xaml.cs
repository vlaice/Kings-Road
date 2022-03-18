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
            str.Page1.exp += 20;
            ClassPage.Class1.Pagew.Navigate(new lesson2.l2());
        }
    }
}
