using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.ViewModels.GiaoDan;
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

namespace QuanLyGiaoXu.Views.GiaoDan
{
    /// <summary>
    /// Interaction logic for ThemGiaoDan.xaml
    /// </summary>
    public partial class ThemGiaoDan : UserControl
    {
        public ThemGiaoDanViewModel ViewModel { get; set; }
        private List<string> GioiList;

        public ThemGiaoDan()
        {
            ViewModel = new ThemGiaoDanViewModel();
            GioiList = new List<string>();
            InitializeComponent();
            addGioilist(GioiList);

            Gioicbx.ItemsSource = GioiList;
            this.DataContext = ViewModel;
        }

        private void HoTentxtbx_LostFocus(object sender, RoutedEventArgs e)
        {
            HoTentxtbx.Text = GiaoXuHelper.convert(HoTentxtbx.Text);
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.CreateGiaoDan();

        }
        private void addGioilist(List<string> GioiList)
        {
            GioiList.Add("Thiếu Nhi");
            GioiList.Add("Giới Trẻ");
            GioiList.Add("Gia Trưởng");
            GioiList.Add("Hiền Mẫu");
            GioiList.Add("Cao Niên");
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TenThanhtxtbx.Focus();
        }
    }
}
