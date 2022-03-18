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
    /// Логика взаимодействия для Registr.xaml
    /// </summary>
    public partial class Registr : Page
    {
       
        public Registr()
        {
            InitializeComponent();
            ApplicationContects.end = new TT3();
        }

       

        private void one1_Click(object sender, RoutedEventArgs e)
        {
            ClassPage.Class1.ptree.Navigate(new str.Lg());
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(box1.Text) || string.IsNullOrEmpty(box2.Text) ||  string.IsNullOrEmpty(LogIN.Text) || string.IsNullOrEmpty(Password.Password))
            {
                MessageBox.Show("Все поля должны быть заполнены!!!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                return;
            }
            else
            {
                using (var BD = new TT3())
                {
                    var user = BD.Profile.AsNoTracking().FirstOrDefault(u => u.Name == LogIN.Text && u.Password == Password.Password);
                    if (user != null)
                    {
                        MessageBox.Show("Данный пользователь уже существует", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        return;
                    }
                    else
                    {

                        Profile us = new Profile()
                        {
                            Name = box1.Text,
                            Surname = box2.Text,
                            Login = LogIN.Text,
                            Password = Password.Password,
                            Exp = 0



                        };
                        ApplicationContects.end.Profile.Add(us);
                        ApplicationContects.end.SaveChanges();
                        MessageBox.Show("Вы добавлены!!!", "", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                        
                    }

                }
            }


            Class1.ptree.Navigate(new str.Lg());
        }

        private void box1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void box1_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                box2.Focus();
            }
        }

        private void box2_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Down)
            {
                LogIN.Focus();
            }
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

        private void LogIN_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                box2.Focus();
            }
        }

        private void box2_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                box1.Focus();
            }
        }
    }
}
