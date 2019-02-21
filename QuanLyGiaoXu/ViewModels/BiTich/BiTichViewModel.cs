using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.BiTich
{
    public class BiTichViewModel : ViewModelBase
    {
        private readonly BackgroundWorker worker = new BackgroundWorker(); // for multithreads
        private ObservableCollection<BiTichViewModelBase> _BiTichMenu;
        public ObservableCollection<BiTichViewModelBase> BiTichMenu
        {
            get { return this._BiTichMenu; }
            set
            {
                _BiTichMenu = value;
                //RaisedPropertyChanged("BiTichMenu");
            }
        }

        public BiTichViewModel()
        {
            worker.DoWork += worker_DoWork;
            worker.RunWorkerCompleted += worker_RunWorkerCompleted;
            worker.RunWorkerAsync();
        }

        ObservableCollection<BiTichViewModelBase> tmp_BiTichMenu = new ObservableCollection<BiTichViewModelBase>();

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {

            tmp_BiTichMenu.Add(new SoRuaToiViewModel());
            tmp_BiTichMenu.Add(new SoRLLDViewModel());
            tmp_BiTichMenu.Add(new SoThemSucViewModel());


            throw new NotImplementedException();
        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            BiTichMenu = tmp_BiTichMenu;
            throw new NotImplementedException();
        }


    }
}
