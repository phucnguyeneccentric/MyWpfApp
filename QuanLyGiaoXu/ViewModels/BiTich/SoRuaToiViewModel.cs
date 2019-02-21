using QuanLyGiaoXu.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.BiTich
{
    public class SoRuaToiViewModel : BiTichViewModelBase
    {
        public override string Name => InventoryHelper.SoRuaToi;

        public override string Icon => InventoryHelper.SoRuaToiIcon;
    }
}
