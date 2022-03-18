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
using diplom.ClassPage;
using System.Data;
using System.Data.SqlClient;
using diplom.str;

namespace diplom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            Class1.Pagew = Pagew;
            Class1.fr2 = fr2;
            WindowState = WindowState.Maximized;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private bool flag = false;
        

       

        

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (flag)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
            flag = !flag;
        }

        

        

        private void one_Click(object sender, RoutedEventArgs e)
        {
            Pagew.Navigate(new str.Page1());
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pagew.Navigate(new str.Page1());
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (flag)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
            flag = !flag;
        }

        private void Pagew_Navigated(object sender, NavigationEventArgs e)
        {
            
        }    
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=localhost;Initial Catalog=hit;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Profile SET Exp = '"+Page1.exp+"' WHERE ID = '"+UserSession.UserId+"'", sqlConnection);
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        private void ong_Click(object sender, RoutedEventArgs e)
        {
            Pagew.Navigate(new str.Page1());

        }
    }
}
