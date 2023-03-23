using IBService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
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
    /// Логика взаимодействия для PRecovery.xaml
    /// </summary>
    public partial class PRecovery : Page
    {
        User contextUser;
        public PRecovery(User user)
        {
            InitializeComponent();
            App.MainWindowInstance.BBack.Visibility = Visibility.Visible;
            contextUser = user;
            DataContext = contextUser;
        }
    }
}
