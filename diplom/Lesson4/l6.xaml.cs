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

namespace diplom.Lesson4
{
    /// <summary>
    /// Логика взаимодействия для l6.xaml
    /// </summary>
    public partial class l6 : Page
    {
        public l6()
        {
            InitializeComponent();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            Class1.Pagew.Navigate(new str.Page1());
        }
    }
}
