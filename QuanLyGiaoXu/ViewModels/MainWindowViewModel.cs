using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using QuanLyGiaoXu.Views.ThieuNhi;
using System.Collections.ObjectModel;
using QuanLyGiaoXu.ViewModels.ThieuNhi;

namespace QuanLyGiaoXu.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {

        

        public MainWindowViewModel()
        {
            
        }
        
        private ICommand _thieuNhiWindow;


        public ICommand ThieuNhiWindow
        {
            get
            {
                if (_thieuNhiWindow == null)
                {
                    _thieuNhiWindow = new RelayCommand(OpenThieuNhi);
                }
                return _thieuNhiWindow;
            }
            set
            {
                _thieuNhiWindow = value;
                OnPropertyChanged("OpenThieuNhi");

            }
        }

        private void OpenThieuNhi()
        {
            //MainThieuNhi tn = new MainThieuNhi();
            //tn.ShowDialog();
           // Framecon.Navigate(new MainThieuNhi());
              Console.WriteLine("fdfd");
        }
        

    }
}
