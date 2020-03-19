using BusinessTier;
using DataLayer;
using EntityTier;
using MaterialDesignExtensions.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.Helpers
{
    public class GiaoDanAutoCompleteSource : IAutocompleteSource
    {
        private List<GiaoDan> _ListGiaoDan;

        public GiaoDanAutoCompleteSource()
        {
            _ListGiaoDan = GiaoDanServices.GetAllActiveGiaoDan();
        }

        public IEnumerable Search(string searchTerm)
        {
            searchTerm = searchTerm ?? string.Empty;
            searchTerm = searchTerm.ToLower();

            return _ListGiaoDan.Where(item => item.HoTen.ToLower().Contains(searchTerm));
        }

        
    }
}
