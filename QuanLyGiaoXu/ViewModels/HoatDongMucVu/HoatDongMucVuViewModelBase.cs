using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.ViewModels.HoatDongMucVu
{
    public abstract class HoatDongMucVuViewModelBase : ViewModelBase
    {
        public abstract string Name { get; }
        public abstract string Icon { get; }

    }
}
