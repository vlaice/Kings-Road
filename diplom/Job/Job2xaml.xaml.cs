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

namespace diplom.Job
{
    /// <summary>
    /// Логика взаимодействия для Job2xaml.xaml
    /// </summary>
    public partial class Job2xaml : Page
    {
        public Job2xaml()
        {
            InitializeComponent();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new lesson2.l1());
        }
    }
}
