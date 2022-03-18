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

namespace diplom.str
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public static int exp = UserSession.UserExp;

        public Page1()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Job.Job1());
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Job.Job2xaml());

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (exp >= 100)
            {
                b2.IsEnabled = true;
            }
            if (exp >= 200)
            {
                b3.IsEnabled = true;
            }
            if (exp >= 300)
            {
                b4.IsEnabled = true;
            }

            ExpTxbl.Text = exp.ToString();
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Job.Job3());
        }

        private void b1_Copy_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new str.Pr());
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Job.Job4());
        }

        private void b4_Copy_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new Job.Job5());
        }
    }
}
