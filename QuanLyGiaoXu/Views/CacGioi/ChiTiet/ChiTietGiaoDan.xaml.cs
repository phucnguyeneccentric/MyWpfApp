using QuanLyGiaoXu.Mediators;
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

namespace QuanLyGiaoXu.Views.CacGioi.ChiTiet
{
    /// <summary>
    /// Interaction logic for ChiTietGiaoDan.xaml
    /// </summary>
    public partial class ChiTietGiaoDan : Window, IDisposable
    {
        private ChiTietGiaoDanDirector _mediator;
        public ChiTietGiaoDan(ChiTietGiaoDanDirector mediator)
        {
            InitializeComponent();
            _mediator = mediator;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);
            this.DragMove();
        }

        #region IDisposable

        void IDisposable.Dispose()
        {
            _mediator.Dispose();
            _mediator = null;
        }

        #endregion IDisposable
    }
}
