using EntityTier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan
{
    public class ChiTietGiaoDanEditModeVM : ViewModelBase
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


    }
}
