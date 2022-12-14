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
using UI_PR_TASK4.View.UserControls;

namespace UI_PR_TASK4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnOpenMenu.Visibility = Visibility.Visible;
            BtnCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnCloseMenu.Visibility = Visibility.Visible;
            BtnOpenMenu.Visibility = Visibility.Collapsed;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            BtnCloseMenu.Visibility = Visibility.Collapsed;
            BtnOpenMenu.Visibility = Visibility.Visible;
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UserControl userControl = null;
            GridMain.Children.Clear();

            switch (((ListViewItem)((ListView)sender).SelectedItem).Name)
            {
                case "LVItemProfile":
                    userControl = new ProfileUserControl();
                    GridMain.Children.Add(userControl);
                    break;
                case "LVItemNotes":
                    userControl = new NotesUserControl();
                    GridMain.Children.Add(userControl);
                    break;
                case "LVItemStocks":
                    userControl = new StocksUserControl();
                    GridMain.Children.Add(userControl);
                    break;
                case "LVItemChat":
                    userControl = new ChatUserControl1();
                    GridMain.Children.Add(userControl);
                    break;
                case "LVItemNotifications":
                    userControl = new NotificationsUserControl();
                    GridMain.Children.Add(userControl);
                    break;
                case "LVItemLogout":
                    Application.Current.Shutdown();
                    break;
                default:
                    break;
            }
        }
    }
}
