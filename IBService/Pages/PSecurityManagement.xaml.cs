using IBService.Model;
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
    /// Логика взаимодействия для PSecurityManagement.xaml
    /// </summary>
    public partial class PSecurityManagement : Page
    {
        User employee;
        public PSecurityManagement(User user)
        {
            InitializeComponent();
            employee = user;
            Refresh();
            TBFullName.Text = $"{user.Surname} {user.Name[0]}. {user.Patronymic[0]}.";
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.SaveChanges();
            Refresh();
        }
        private void Refresh()
        {
            App.MainWindowInstance.BBack.Visibility = Visibility.Visible;
            CBType.ItemsSource = App.DB.Type.ToList();
            if (TCManagment.SelectedIndex == 0)
                BSave.Content = "Одобрить";
                DGUsersVerification.ItemsSource = App.DB.User.Where(u => u.Login == null || u.Type == null || u.Password == null || u.SecretWord == null || u.Approved == false).ToList();
            if (TCManagment.SelectedIndex == 1)
                BSave.Content = "Применять";
                DGUsersMandats.ItemsSource = App.DB.User.Where(u => u.Approved == true && u.AddData == null && u.ViewData == null && u.Reports == null ).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }

        //private void TCManagment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (TCManagment.SelectedIndex == 0)
        //        BSave.Content = "Одобрить";
        //    if (TCManagment.SelectedIndex == 1)
        //        BSave.Content = "Применять";
        //    Refresh();
        //}
    }
}
