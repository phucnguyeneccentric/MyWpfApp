using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.ThieuNhi
{
    public class ThieuNhiViewModel : ViewModelBase
    {
        

        private readonly BackgroundWorker worker = new BackgroundWorker(); // for multithreads
        private ObservableCollection<ThieuNhiViewModelBase> _ThieuNhiMenu;
        public ObservableCollection<ThieuNhiViewModelBase> ThieuNhiMenu
        {
            get { return this._ThieuNhiMenu; }
            set
            {
                _ThieuNhiMenu = value;
                //RaisedPropertyChanged("ThieuNhiMenu");
            }
        }
        public ThieuNhiViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        ObservableCollection<ThieuNhiViewModelBase> tmp_ThieuNhiMenu = new ObservableCollection<ThieuNhiViewModelBase>();



        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            tmp_ThieuNhiMenu.Add(new DanhSachThieuNhiViewModel());
            tmp_ThieuNhiMenu.Add(new ThemThieuNhiViewModel());
            tmp_ThieuNhiMenu.Add(new ThongTinThieuNhiViewModel());


        }


        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ThieuNhiMenu = tmp_ThieuNhiMenu;
        }
    }
}
