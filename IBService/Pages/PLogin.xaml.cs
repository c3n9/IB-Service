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

namespace IBService.Pages
{
    /// <summary>
    /// Логика взаимодействия для PLogin.xaml
    /// </summary>
    public partial class PLogin : Page
    {
        public PLogin()
        {
            InitializeComponent();
            Refresh();
        }

        private void HLRecovery_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(u => u.Login == TBLogin.Text);
            if (user == null && user.TypeId == 2)
            {
                MessageBox.Show("Введите логин для восстановления");
                return;
            }
            NavigationService.Navigate(new PRecovery(user));
        }

        private void BLogin_Click(object sender, RoutedEventArgs e)
        {
            var user = App.DB.User.FirstOrDefault(u => u.Login == TBLogin.Text);
            string error = "";
            if (user == null || user.TypeId != 2)
            {
                MessageBox.Show("Неверный логин");
                return;
            }
            if (user.Password != TBPassword.Text)
            {
                error += "Неверный пароль\n";
            }
            if (user.SecretWord != TBSecretWord.Text)
            {
                error += "Неверное секретное слово\n";
            }
            if (CBType.SelectedIndex != 1)
            {
                error += "Неверный тип пользователя\n";
            }
            if (!String.IsNullOrWhiteSpace(error))
            {
                MessageBox.Show(error);
                return;
            }
            if (user.TypeId == 2 && user.Password == TBPassword.Text && user.SecretWord == TBSecretWord.Text)
            {
                NavigationService.Navigate(new PSecurityManagement(user));
            }
        }
        private void Refresh()
        {
            CBType.ItemsSource = App.DB.Type.ToList();
            App.MainWindowInstance.BBack.Visibility = Visibility.Collapsed;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
