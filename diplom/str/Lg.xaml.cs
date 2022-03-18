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
using diplom.str;
using diplom;

namespace diplom.str
{
    /// <summary>
    /// Логика взаимодействия для Lg.xaml
    /// </summary>
    public partial class Lg : Page
    {
        public static string Login { get; set; }
        public static string Passwrd { get; set; }
        public Lg()
        {
            InitializeComponent();
            ApplicationContects.end = new TT3();



        }
        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LogIN.Text) || string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Введите логин и пароль!!!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                using (var bd = new TT3())
                {
                    var user = bd.Profile.AsNoTracking().FirstOrDefault(u => u.Login == LogIN.Text && u.Password == Password.Password);
                    if (user == null)
                    {
                        MessageBox.Show("Возможно вы ввели неверно логин или пароль. Пожалуйста повторите попытку или зарегистрируйтесь", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return;
                    }
                    else
                    {
                        Login = LogIN.Text;
                        Passwrd = Password.Password;
                        UserSession.GetUserInfo(LogIN);
                        MainWindow taskWindow = new MainWindow();
                        taskWindow.Show();

                        Application.Current.MainWindow.Close();
                    }
                }
            }


        }



        private void box2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void one1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.ptree.Navigate(new str.Registr());
        }
        private void LogIN_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void one_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void LogIN_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                Password.Focus();
            }
        }

        private void Password_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                LogIN.Focus();
            }
        }
    }
}
