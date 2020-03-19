using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyGiaoXu.Helpers
{
    public class GiaoXuHelper
    {
        #region MenuGiaoDan
        public static string DanhSachGiaoDan = "Danh Sách Giáo Dân";
        public static string ChuyenXu = "Chuyển Xứ";
        public static string DanhSachGiaoDanIcon = "Database";
        public static string ChuyenXuIcon = "Database";
        #endregion

        #region MenuBiTich
        public static string SoRuaToi = "Sổ Rửa Tội";
        public static string SoRLLD = "Sổ Rước Lễ Lần Đầu";
        public static string SoThemSuc = "Sổ Thêm Sức";

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

        public static string SplitLastName(string Name)
        {
            string _lastName = string.Empty;
            string[] _spltname = Name.Split(' ');
            for (int i = 0; i < _spltname.Length - 1; i++)
            {
                _lastName = _lastName + _spltname[i] + ' ';
            }
            return _lastName.Trim();
        }

        public static string SplitFirstName(string Name)
        {
            string _firstName = string.Empty;
            string[] _spltname = Name.Split(' ');

            _firstName = _spltname.LastOrDefault();
            return _firstName.Trim();
        }
        
        public static string UnionDayMonthYear(int Day, int Month, int Year)
        {
            string _date = string.Empty;
            _date = Day.ToString() + "/" + Month.ToString() + "/" + Year.ToString();
            return _date;
        }


        public static string ToFirstUpper(string s)  
        {  
            if (String.IsNullOrEmpty(s))  
                return s;  

            string result = "";  

            //lấy danh sách các từ  

            string[] words = s.Split(' ');  

            foreach (string word in words)  
            {  
                // từ nào là các khoảng trắng thừa thì bỏ  
                if (word.Trim() != "")  
                {  
                    if (word.Length > 1)  
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";  
                    else  
                        result += word.ToUpper() + " ";  
                }  

            }  
            return result.Trim();  
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
