using BusinessTier;
using MaterialDesignExtensions.Model;
using System;
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

    public class GiaoXuSuggestionsSource : TextBoxSuggestionsSource
    {
        private List<string> m_danhsachgiaoxu;

        public GiaoXuSuggestionsSource()
        {
            m_danhsachgiaoxu = DiaChiServices.GetListGiaoHo();


        }

        public override IEnumerable<string> Search(string searchTerm)
        {
            searchTerm = searchTerm ?? string.Empty;
            searchTerm = searchTerm.ToLower();

            return m_danhsachgiaoxu.Where(item => item.ToLower().Contains(searchTerm));
        }
    }

}
