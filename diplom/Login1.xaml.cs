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
using System.Windows.Shapes;
using diplom.ClassPage;
using System.Data;
using System.Data.SqlClient;


namespace diplom
{
    /// <summary>
    /// Логика взаимодействия для Login1.xaml
    /// </summary>
    public partial class Login1 : Window
    {

        ClassPage.ApplicationContects  bd;
        
        public Login1()
        {
            InitializeComponent();
            bd = new ApplicationContects();
            Class1.ptree = ptree;
            ptree.Navigate(new str.Lg());
        }
        
        
        private void one_Click(object sender, RoutedEventArgs e)
        {
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            

            
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void one_Click_1(object sender, RoutedEventArgs e)
        {

        }

       
    }
}
