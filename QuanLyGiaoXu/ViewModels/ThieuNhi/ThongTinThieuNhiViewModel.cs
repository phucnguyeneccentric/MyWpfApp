using QuanLyGiaoXu.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.ThieuNhi
{
    public class ThongTinThieuNhiViewModel : ThieuNhiViewModelBase
    {
        public override string Name => InventoryHelper.ThongTinThieuNhi;

        public override string Icon => InventoryHelper.ThongTinThieuNhiIcon;
    }
}
