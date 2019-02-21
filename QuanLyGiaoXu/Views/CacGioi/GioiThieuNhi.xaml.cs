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
    /// Interaction logic for GioiThieuNhi.xaml
    /// </summary>
    public partial class GioiThieuNhi : UserControl
    {
        List<string> GiaoHolst;
        public GioiThieuNhi()
        {
            GiaoHolst = new List<string>();
            AddListGiaoHo(GiaoHolst);


            InitializeComponent();
            GiaoHocbx.ItemsSource = GiaoHolst;

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


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
    

    
}
