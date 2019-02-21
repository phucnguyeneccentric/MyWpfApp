using EntityTier;
using QuanLyGiaoXu.ViewModels.CacGioi;
using QuanLyGiaoXu.ViewModels.CacGioi.ChiTietGiaoDan;
using QuanLyGiaoXu.Views.CacGioi.ChiTiet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.Mediators
{
    public class ChiTietGiaoDanDirector : EditDialogDirector<ChiTietGiaoDanEditViewModel>
    {
        public ChiTietGiaoDanDirector(GiaoDanEntity giaoDan)
        {
            Dialog = new ChiTietGiaoDan(this);
            (_vm as ChiTietGiaoDanEditViewModel).GiaoDan = giaoDan;
            (_vm as ChiTietGiaoDanEditViewModel).CurrentView = new ChiTietGiaoDanWatchModeVM(giaoDan);
        }
    }
}
