using QuanLyGiaoXu.ViewModels.GiaoDan;
using QuanLyGiaoXu.ViewModels.HoatDongMucVu;
using QuanLyGiaoXu.ViewModels.HoatDongMucVu.ChuyenXu;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.GiaoDan
{
    public class GiaoDanViewModel : ViewModelBase
    {
        private readonly BackgroundWorker worker = new BackgroundWorker(); // for multithreads
        private ObservableCollection<GiaoDanViewModelBase> _GiaoDanMenu;
        public ObservableCollection<GiaoDanViewModelBase> GiaoDanMenu
        {
            get { return this._GiaoDanMenu; }
            set
            {
                _GiaoDanMenu = value;
                OnPropertyChanged("GiaoDanMenu");
            }
        }

        private ObservableCollection<HoatDongMucVuViewModelBase> _hoatdongmucvu;
        public ObservableCollection<HoatDongMucVuViewModelBase> HoatDongMucVu
        {
            get { return this._hoatdongmucvu; }
            set
            {
                _hoatdongmucvu = value;
                OnPropertyChanged("HoatDongMucVu");
            }
        }
        public GiaoDanViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        ObservableCollection<GiaoDanViewModelBase> tmp_GiaoDanMenu = new ObservableCollection<GiaoDanViewModelBase>();
        ObservableCollection<HoatDongMucVuViewModelBase> tmp_hoatdongmucvu = new ObservableCollection<HoatDongMucVuViewModelBase>();


        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            tmp_GiaoDanMenu.Add(new DanhSachGiaoDanViewModel());
            tmp_hoatdongmucvu.Add(new DanhSachChuyenXuViewModel());
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            GiaoDanMenu = tmp_GiaoDanMenu;
            HoatDongMucVu = tmp_hoatdongmucvu;
        }
    }
}
