using EntityTier;
using QuanLyGiaoXu.Mediators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanWatchModeVM : ViewModelBase
    {

        #region Fields

        private GiaoDanEntity _giaodan;

        #endregion Fields

        /// <summary>
        /// Du lieu giao dan
        /// </summary>
        public GiaoDanEntity GiaoDan
        {
            get { return _giaodan; }
            set
            {
                _giaodan = value;
                OnPropertyChanged("GiaoDan");
            }
        }
        public ChiTietGiaoDanWatchModeVM(GiaoDanEntity giaoDan)
        {
            this.GiaoDan = giaoDan;
        }
        
    }
}
