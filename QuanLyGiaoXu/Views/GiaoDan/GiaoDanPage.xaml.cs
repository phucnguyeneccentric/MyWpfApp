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
            if(ListGiaoDanMenu.SelectedIndex != -1)
            {
                HoatDongMucVu.SelectedIndex = -1;
                ChucNangCtrl.Content = ListGiaoDanMenu.SelectedItem;
            }

        }

        private void HoatDongMucVu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(HoatDongMucVu.SelectedIndex != -1)
            {
                ListGiaoDanMenu.SelectedIndex = -1;
                ChucNangCtrl.Content = HoatDongMucVu.SelectedItem;
            }
           
        }
    }
}
