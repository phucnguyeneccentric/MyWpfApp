using QuanLyGiaoXu.ViewModels.GiaoDan;
using System.Windows;
using System.Windows.Controls;

namespace QuanLyGiaoXu.Views.CacGioi
{
    /// <summary>
    /// Interaction logic for CacGioiPage.xaml
    /// </summary>
    public partial class GiaoDanPage : Page
    {
        public GiaoDanPage()
        {
            InitializeComponent();
            this.DataContext = new GiaoDanViewModel();
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
