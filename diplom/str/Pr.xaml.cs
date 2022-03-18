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
    /// Логика взаимодействия для Pr.xaml
    /// </summary>
    public partial class Pr : Page
    {
        public Pr()
        {
            InitializeComponent();
            ClassPage.Class2.ent = new TT3();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.Pagew.Navigate(new str.Page1());
        }

        private void lb_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            NameTxbl.Text = UserSession.UserName;
            SurnameTxbl.Text = UserSession.UserSurname;
            ExpTxbl.Text = Page1.exp.ToString();
            
        }

        private void one_Click_1(object sender, RoutedEventArgs e)
        {
            Class1.Pagew.Navigate(new str.Page1());
        }
    }
}
