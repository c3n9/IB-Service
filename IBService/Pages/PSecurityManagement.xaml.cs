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
            //TBFullName.Text = $"{user.Surname} {user.Name[0]}. {user.Patronymic[0]}.";
        }

        private void BSave_Click(object sender, RoutedEventArgs e)
        {
            App.DB.SaveChanges();
            Refresh();
        }
        private void Refresh()
        {
            CBType.ItemsSource = App.DB.Type.ToList();
            DGUsers.ItemsSource = App.DB.User.Where(u => u.Login == null || u.Type == null || u.Password == null || u.SecretWord == null).ToList();
        }
    }
}
