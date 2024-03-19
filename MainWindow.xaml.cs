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

namespace DrawerPractise
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CloseMenu();
        }

        void OpenMenus()
        {
            ButtonMenuOpen.Visibility = Visibility.Collapsed;
            MenuClosebtn.Visibility = Visibility.Visible;
        }
        void CloseMenu()
        {
            ButtonMenuOpen.Visibility = Visibility.Visible;
            MenuClosebtn.Visibility = Visibility.Collapsed;
        }
        private void Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Opendrawer(object sender, RoutedEventArgs e)
        {
            OpenMenus();
        }

        private void Closedrawer(object sender, RoutedEventArgs e)
        {
            CloseMenu();
        }
    }
}
