using QuanLyGiaoXu.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.ThieuNhi
{
    public class ThemThieuNhiViewModel : ThieuNhiViewModelBase
    {
        public override string Name => InventoryHelper.ThemThieuNhi;

        public override string Icon => InventoryHelper.ThemThieuNhiIcon;
    }
}
