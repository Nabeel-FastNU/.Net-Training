using System;

//Different Namespace

namespace DailyLifeProject.Extensions
{
    //DateTIme Class Extension Method

    static class DateTimeExtension
    {
        public static string Print_DateTime(this DateTime D)
        {
            string Clck_Hr = "AM";
            int Hour;
            if (D.Hour >= 12)
            {
                Clck_Hr = "PM";
                Hour = D.Hour - 12;
            }
            else Hour = D.Hour;


            return (D.Day + "/" + D.Month + "/" + D.Year + " " + Hour + ":" + D.Minute + " " + Clck_Hr);
        }
    }
}
