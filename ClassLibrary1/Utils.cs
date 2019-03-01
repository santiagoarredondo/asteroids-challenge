using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Utils
    {

        Connection c = new Connection(@"aqSXasG5NLdhh7TBbIeKXJT3VhrkNwD3PSJDrMba",@"2015-09-07",@"2015-09-08");
        private static string key= @"aqSXasG5NLdhh7TBbIeKXJT3VhrkNwD3PSJDrMba";
        private static string startDate = @"2015-09-07";
        private static string endDate = @"2015-09-08";

        private static string GetLink() { return (@"https://api.nasa.gov/neo/rest/v1/feed?start_date=" + startDate + @"&end_date=" + endDate + @"&api_key=" + key); }

        public static string link = GetLink();

        private static DateTime CurrentDate() => DateTime.Today;

        public static string DateToString(DateTime date, string format)
        {
            return date.ToString("yyyy-MM-dd") ?? null;
        }

        public static DateTime getDefaultDate()
        {
            //string date = (CurrentDate().Month.Equals(1)) ? ((CurrentDate().Year - 1) + "/12/01") : ((CurrentDate().Year) + "/" + ToZeroFormat(CurrentDate().Month - 1) + "/01");
            //string[] dateElements = date.Split("/");
            DateTime lastMonthFromCurrent =  CurrentDate().AddMonths(-1);
            return new DateTime(lastMonthFromCurrent.Year, lastMonthFromCurrent.Month, 1);
        }

        public static string ToZeroFormat(int number)
        {
            return (number<10) ? "0"+number : number.ToString();
        }

        public static void SetKey(string key)
        {
            
        }

        public static void SetStartDate(string startDate)
        {

        }

        public static void SetEndDate(string endDate)
        {

        }

    }

    public class Connection
    {
        private string key { get; set; }
        private string startDate { get; set; }
        private string endDate { get; set; }

        public Connection(string newKey, string newStartDate, string newEndDate)
        {
            key = newKey;
            startDate = newStartDate;
            endDate = newEndDate;
        }
    }
}
