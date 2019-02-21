using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.Helpers
{
    public class InventoryHelper
    {
        #region MenuThieuNhi
        public static string ThemThieuNhi = "Thêm Thiếu Nhi";
        public static string DanhSachThieuNhi = "Danh Sách Thiếu Nhi";
        public static string ThongTinThieuNhi = "Sơ Yếu Lý Lịch";
       
        #endregion

        #region IconsThieuNhi
        public static string ThemThieuNhiIcon = "Add";
        public static string DanhSachThieuNhiIcon = "Database";
        public static string ThongTinThieuNhiIcon = "InformationVariant";
        #endregion

        #region MenuBiTich
        public static string SoRuaToi = "Sổ Rửa Tội";
        public static string SoRLLD = "Sổ Rước Lễ Lần Đầu";
        public static string SoThemSuc = "Sổ Thêm Sức";

        #endregion

        #region IconsBiTich
        public static string SoRuaToiIcon = "BookOpen";
        public static string SoRLLDIcon = "BookOpen";
        public static string SoThemSucIcon = "BookOpen";
        #endregion

        #region MenuCacGioi
        public static string GioiThieuNhi = "Giới Thiếu Nhi";

        #endregion

        #region IconsCacGioi
        public static string GioiThieuNhiIcon = "Baby";
        #endregion



        public static string GetSaveFilePath()
        {
            string DirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string FolderName = "QuanLyGiaoXu";
            DirectoryPath += @"\" + FolderName;
            if (!Directory.Exists(DirectoryPath))
            {
                Directory.CreateDirectory(DirectoryPath);
            }
            return DirectoryPath;
        }

        


        public static DateTime GetFirstDateOfWeek(DateTime dayInWeek, DayOfWeek RunningDay)  //RunningDay is Schedular Running day 
        {
            DateTime firstDayInWeek = dayInWeek.Date;
            while (firstDayInWeek.DayOfWeek != RunningDay)
                firstDayInWeek = firstDayInWeek.AddDays(-1);

            return firstDayInWeek;
        }
        public static DateTime GetLastDateOfWeek(DateTime dayInWeek, DayOfWeek RunningDay)
        {
            DateTime lastDayInWeek = dayInWeek.Date;
            while (lastDayInWeek.DayOfWeek != RunningDay)
                lastDayInWeek = lastDayInWeek.AddDays(1);

            return lastDayInWeek;
        }

        public static DateTime GetLastDayOfMonth()
        {
            DateTime firstOfNextMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1);
            DateTime lastOfThisMonth = firstOfNextMonth.AddDays(-1);
            return lastOfThisMonth;
        }

        public static DateTime GetLastWeekdayOfMonth(DateTime date, DayOfWeek day)         // Get last WeekdayofMonth according to day
        {
            DateTime lastDayOfMonth = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
            int wantedDay = (int)day;
            int lastDay = (int)lastDayOfMonth.DayOfWeek;
            return lastDayOfMonth.AddDays(lastDay >= wantedDay ? wantedDay - lastDay : wantedDay - lastDay - 7);
        }

        public static DateTime GetMonthFirstday(DateTime date)
        {
            DateTime FirstDay = new DateTime(date.Year, date.Month, 1);
            return FirstDay;
        }

        public static DateTime GetMonthLastday(DateTime date)
        {
            DateTime firstDayOfTheMonth = new DateTime(date.Year, date.Month, 1);
            return firstDayOfTheMonth.AddMonths(1).AddDays(-1);
        }

        public static bool CheckWeekEndDay()
        {
            DateTime currentdate = DateTime.Now.Date;
            DateTime lastDayInWeek = GetLastDateOfWeek(DateTime.Now, DayOfWeek.Sunday);
            if (currentdate == lastDayInWeek)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static bool CheckMonthWeekEndDay()
        {
            DateTime currentdate = DateTime.Now.Date;
            DateTime monthlastweekend = GetLastWeekdayOfMonth(DateTime.Now, DayOfWeek.Sunday);
            if (currentdate == monthlastweekend)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //public static string DynamicConnectionString
        //{
        //    get
        //    {
        //        return @"metadata=res://*/Inventory.csdl|res://*/Inventory.ssdl|res://*/Inventory.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + ServerConnection.Default.ServerName + ";initial catalog=" + ServerConnection.Default.DatabaseName + ";user id=" + ServerConnection.Default.UserName + ";password=" + ServerConnection.Default.Password + ";MultipleActiveResultSets=True;App=EntityFramework';";
        //    }
        //}



    }

}
