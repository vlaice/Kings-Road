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
    /// Логика взаимодействия для Job1.xaml
    /// </summary>
    public partial class Job1 : Page
    {
        public Job1()
        {
            InitializeComponent();
        }

        

        private void one_Click_1(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Lesson1.l1());
        }
    }
}
