using QuanLyGiaoXu.Views.CacGioi;
using QuanLyGiaoXu.Views.ThieuNhi;
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

namespace QuanLyGiaoXu.Views.MainPage
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            this.DataContext = new ViewModels.MainWindowViewModel();
        }


        private void GiaoDanbtn_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new GiaoDanPage());
           
        }
    }
}
