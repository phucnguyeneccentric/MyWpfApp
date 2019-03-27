using MaterialDesignThemes.Wpf;
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
    /// Interaction logic for DanhSachGiaoDan.xaml
    /// </summary>
    public partial class DanhSachGiaoDan : UserControl
    {
        private List<string> GiaoHolst;

        public DanhSachGiaoDan()
        {
            InitializeComponent();
            GiaoHolst = new List<string>();
            AddListGiaoHo(GiaoHolst);
            GiaoHocbx.ItemsSource = GiaoHolst;
            // Requires: using System.Windows.Data
        }

        private void AddListGiaoHo(List<string> GiaoHolst)
        {
            GiaoHolst.Add("Rạng Đông");
            GiaoHolst.Add("Tử Đạo");
            GiaoHolst.Add("Truyền Tin");
            GiaoHolst.Add("Mân Côi");
            GiaoHolst.Add("La Vang");
            GiaoHolst.Add("Mẹ Thiên Chúa");
            GiaoHolst.Add("Thăm Viếng");
            GiaoHolst.Add("Trinh Vương");
            GiaoHolst.Add("Martino");
            GiaoHolst.Add("Giuse Thợ");
            GiaoHolst.Add("Bàu Mây");
        }

        


       
    }
    

    
}
