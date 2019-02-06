using System;
using System.Globalization;
using System.Linq;

namespace DateConsole
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            CalendarEnum calendarSource, calendarTarget;
            calendarSource = calendarTarget = Enum.Parse<CalendarEnum>(args[0]);

            var dt = args[1].Split('-').Where(c => !string.IsNullOrEmpty(c)).Select(c => int.Parse(c)).ToArray();

            DateTime dateSource = new DateTime(dt[0], dt[1], dt[2], calendarSource.GetCalendar());

            Console.WriteLine(dateSource.ToString("D"));



        }
    }



    public enum CalendarEnum
    {
        Gregorian,
        Hebrew,
        UmAlQura,
        Hijri,
        Japanese,
        JapaneseLunisolar,
        Julian,
        Korean,
        KoreanLunisolar,
        Persian,
        Taiwan,
        TaiwanLunisolar,
        ThaiBuddhist,
    }

    public static class CalendarExtension
    {

        public static Calendar GetCalendar(this CalendarEnum self)
        {

            Calendar calendar = null;
            switch (self)
            {

                case CalendarEnum.Hebrew:
                    calendar = new HebrewCalendar();
                    break;
                case CalendarEnum.UmAlQura:
                    calendar = new UmAlQuraCalendar();
                    break;
                case CalendarEnum.Hijri:
                    calendar = new HijriCalendar();
                    break;
                case CalendarEnum.Japanese:
                    calendar = new JapaneseCalendar();
                    break;
                case CalendarEnum.JapaneseLunisolar:
                    calendar = new JapaneseLunisolarCalendar();
                    break;
                case CalendarEnum.Julian:
                    calendar = new JulianCalendar();
                    break;
                case CalendarEnum.Korean:
                    calendar = new KoreanCalendar();
                    break;
                case CalendarEnum.KoreanLunisolar:
                    calendar = new KoreanLunisolarCalendar();
                    break;
                case CalendarEnum.Persian:
                    calendar = new PersianCalendar();
                    break;
                case CalendarEnum.Taiwan:
                    calendar = new TaiwanCalendar();
                    break;
                case CalendarEnum.TaiwanLunisolar:
                    calendar = new TaiwanLunisolarCalendar();
                    break;

                case CalendarEnum.ThaiBuddhist:
                    calendar = new ThaiBuddhistCalendar();
                    break;

                case CalendarEnum.Gregorian:
                default:
                    calendar = new GregorianCalendar();
                    break;

            }

            return calendar;

        }

    }

}
