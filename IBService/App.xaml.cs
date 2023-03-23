using IBService.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IBService
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static GuardEntities DB = new GuardEntities();
        public static MainWindow MainWindowInstance = new MainWindow();
    }
}
