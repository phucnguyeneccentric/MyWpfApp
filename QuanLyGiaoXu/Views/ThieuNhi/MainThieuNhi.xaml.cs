using QuanLyGiaoXu.ViewModels.ThieuNhi;
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
using System.Windows.Shapes;

namespace QuanLyGiaoXu.Views.ThieuNhi
{
    /// <summary>
    /// Interaction logic for MainThieuNhi.xaml
    /// </summary>
    public partial class MainThieuNhi : Page
    {
        public MainThieuNhi()
        {
            InitializeComponent();
            this.DataContext = new ThieuNhiViewModel();
        }

       
        //private void MoveCursorMenu(int index)
        //{
            
        //    GridCursor.Margin = new Thickness(0, (128 + (55 * index)), 0, 0);
        //    //TrainsitionigContentSlide.OnApplyTemplate();
        //}

        private void ListViewThieuNhiMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           // int index = ListViewThieuNhiMenu.SelectedIndex;
           // MoveCursorMenu(index);
            ChucNangCtrl.Content = ListViewThieuNhiMenu.SelectedItem;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
