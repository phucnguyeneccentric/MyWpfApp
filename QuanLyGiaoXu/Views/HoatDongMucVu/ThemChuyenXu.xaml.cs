using QuanLyGiaoXu.ViewModels.HoatDongMucVu.ChuyenXu;
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

namespace QuanLyGiaoXu.Views.HoatDongMucVu
{
    /// <summary>
    /// Interaction logic for ThemChuyenXu.xaml
    /// </summary>
    public partial class ThemChuyenXu : UserControl
    {
        public ThemChuyenXuViewModel ViewModel { get; set; }
        public ThemChuyenXu()
        {
            InitializeComponent();
            ViewModel = new ThemChuyenXuViewModel();

        }
    }
}
