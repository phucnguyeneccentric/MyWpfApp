using QuanLyGiaoXu.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.CacGioi
{
    class GioiHienMauViewModel : CacGioiViewModelBase
    {
        public override string Name => InventoryHelper.SoRLLD;

        public override string Icon => InventoryHelper.SoRLLDIcon;
    }
}
