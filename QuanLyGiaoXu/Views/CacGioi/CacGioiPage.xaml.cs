using QuanLyGiaoXu.ViewModels.CacGioi;
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

namespace QuanLyGiaoXu.Views.CacGioi
{
    /// <summary>
    /// Interaction logic for CacGioiPage.xaml
    /// </summary>
    public partial class CacGioiPage : Page
    {
        public CacGioiPage()
        {
            InitializeComponent();
            this.DataContext = new CacGioiViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ChucNangCtrl.Content = ListViewMenu.SelectedItem;

        }
    }
}
