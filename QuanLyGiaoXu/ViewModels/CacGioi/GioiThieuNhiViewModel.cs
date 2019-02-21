using DataLayer;
using BusinessTier;
using MaterialDesignThemes.Wpf;
using QuanLyGiaoXu.Helpers;
using QuanLyGiaoXu.Views.CacGioi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EntityTier;
using System.Collections.ObjectModel;
using QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan;

namespace QuanLyGiaoXu.ViewModels.CacGioi
{
    public class GioiThieuNhiViewModel : CacGioiViewModelBase
    {
        #region fields
        public override string Name => InventoryHelper.GioiThieuNhi;
        public override string Icon => InventoryHelper.GioiThieuNhiIcon;
        
        private ObservableCollection<ChiTietGiaoDanViewModel> _ListThieuNhi;
        
        #endregion


        public ObservableCollection<ChiTietGiaoDanViewModel> ListThieuNhi
        {
            get { return this._ListThieuNhi; }
            set
            {
                _ListThieuNhi = value;
                OnPropertyChanged("ListThieuNhi");
            }
        }

        private readonly BackgroundWorker worker = new BackgroundWorker();


        private ObservableCollection<ChiTietGiaoDanViewModel> list_ThieuNhi;

        

        public GioiThieuNhiViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            list_ThieuNhi = new ObservableCollection<ChiTietGiaoDanViewModel>();
            var list = ThieuNhiServices.GetAllActiveThieuNhi();
            foreach (var gd in list)
            {
                var _vm = new ChiTietGiaoDanViewModel();
                _vm.GiaoDan = gd;
                list_ThieuNhi.Add(_vm);
            }
        }
        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ListThieuNhi = list_ThieuNhi;
                          
        }

        
    }
}
