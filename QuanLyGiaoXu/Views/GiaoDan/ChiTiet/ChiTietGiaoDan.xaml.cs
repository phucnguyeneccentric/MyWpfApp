using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan;
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

namespace QuanLyGiaoXu.Views.GiaoDan.ChiTiet
{
    /// <summary>
    /// Interaction logic for ChiTietGiaoDan.xaml
    /// </summary>
    public partial class ChiTietGiaoDan : UserControl
    {
        private List<string> GioiList;

        public ChiTietGiaoDan()
        {
            GioiList = new List<string>();
            InitializeComponent();

            addGioilist(GioiList);
            Gioicbx.ItemsSource = GioiList;

        }
        private void HoTentxtbx_LostFocus(object sender, RoutedEventArgs e)
        {
            HoTentxtbx.Text = GiaoXuHelper.convert(HoTentxtbx.Text);
        }
        private void addGioilist(List<string> GioiList)
        {
            GioiList.Add("Thiếu Nhi");
            GioiList.Add("Giới Trẻ");
            GioiList.Add("Gia Trưởng");
            GioiList.Add("Hiền Mẫu");
            GioiList.Add("Cao Niên");
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            var viewmodel = DataContext as ChiTietGiaoDanEditViewModel;
            viewmodel.SaveInfo();

        }
    }
}
