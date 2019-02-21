using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.CacGioi
{
    public class CacGioiViewModel : ViewModelBase
    {
        private readonly BackgroundWorker worker = new BackgroundWorker(); // for multithreads
        private ObservableCollection<CacGioiViewModelBase> _CacGioiMenu;
        public ObservableCollection<CacGioiViewModelBase> CacGioiMenu
        {
            get { return this._CacGioiMenu; }
            set
            {
                _CacGioiMenu = value;
                OnPropertyChanged("CacGioiMenu");
            }
        }
        public CacGioiViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        ObservableCollection<CacGioiViewModelBase> tmp_CacGioiMenu = new ObservableCollection<CacGioiViewModelBase>();


        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            tmp_CacGioiMenu.Add(new GioiThieuNhiViewModel());
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            CacGioiMenu = tmp_CacGioiMenu;
        }
    }
}
