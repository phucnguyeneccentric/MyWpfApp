using BusinessTier;
using EntityTier;
using MaterialDesignExtensions.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.Mediators
{
    public class GiaoHoSuggestionsSource : TextBoxSuggestionsSource
    {
        private List<string> m_danhsachgiaoho;

        public GiaoHoSuggestionsSource()
        {
            m_danhsachgiaoho = DiaChiServices.GetListGiaoHo();


        }

        public override IEnumerable<string> Search(string searchTerm)
        {
            searchTerm = searchTerm ?? string.Empty;
            searchTerm = searchTerm.ToLower();

            return m_danhsachgiaoho.Where(item => item.ToLower().Contains(searchTerm));
        }
    }

    //public class GiaDinhSuggestionsSource : IAutocompleteSource
    //{
    //    private List<GiaDinhEntity> m_danhsachgiadinh;

    //    public GiaoXuSuggestionsSource()
    //    {
    //        m_danhsachgiaoxu = DiaChiServices.GetListGiaoHo();


    //    }

    //    public  IEnumerable Search(string searchTerm)
    //    {
    //        searchTerm = searchTerm ?? string.Empty;
    //        searchTerm = searchTerm.ToLower();

    //        return m_danhsachgiadinh.Where(item => item.ToLower().Contains(searchTerm));
    //    }

       
    //}

}
