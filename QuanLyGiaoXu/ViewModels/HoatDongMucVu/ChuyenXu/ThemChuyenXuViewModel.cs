using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessTier;
using EntityTier;
using DataLayer;
using MaterialDesignExtensions.Model;
using QuanLyGiaoXu.Mediators;
using System.ComponentModel;
using QuanLyGiaoXu.Helpers;

namespace QuanLyGiaoXu.ViewModels.HoatDongMucVu.ChuyenXu
{
    public class ThemChuyenXuViewModel : ViewModelBase, IDataErrorInfo
    {
        #region Fields
        private IAutocompleteSource _giaodanSource;

        private DataLayer.GiaoDan _selectedGiaoDan;

        #endregion


        #region Properties
        public IAutocompleteSource GiaoDanSource
        {
            get
            {
                return _giaodanSource;
            }
        }


        public DataLayer.GiaoDan SelectedGiaoDan
        {
            get
            {
                return _selectedGiaoDan;
            }

            set
            {
                _selectedGiaoDan = value;

                OnPropertyChanged(nameof(SelectedGiaoDan));
            }
        }
        #endregion


        public ThemChuyenXuViewModel()
            : base()
        {
            _giaodanSource = new GiaoDanAutoCompleteSource();
            _selectedGiaoDan = null;
        }



        #region Validate Errors
        public string this[string columnName] => throw new NotImplementedException();

        public string Error => throw new NotImplementedException();

        #endregion

    }
}
