using QuanLyGiaoXu.ViewModels.BiTich;
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

namespace QuanLyGiaoXu.Views.BiTich
{
    /// <summary>
    /// Interaction logic for BiTichPage.xaml
    /// </summary>
    public partial class BiTichPage : Page
    {
        public BiTichPage()
        {
            InitializeComponent();
            this.DataContext = new BiTichViewModel();
        }

        private void MoveCursorMenu(int index)
        {

            GridCursor.Margin = new Thickness(0, (128 + (55 * index)), 0, 0);
            //TrainsitionigContentSlide.OnApplyTemplate();
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MoveCursorMenu(index);
            ChucNangCtrl.Content = ListViewMenu.SelectedItem;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }
    }
}
