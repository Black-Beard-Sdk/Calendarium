using System.Globalization;

namespace Bb.Calendarium.Configuration
{
    public enum CalendarEnum
    {
        Default,
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

        public static Calendar GetCalendar(this CalendarEnum self, CultureInfo culture = null)
        {

            Calendar calendar = null;
            switch (self)
            {

                case CalendarEnum.Gregorian:
                    calendar = new GregorianCalendar();
                    break;
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

                default:
                    if (culture == null)
                        culture = System.Threading.Thread.CurrentThread.CurrentCulture;
                    calendar = culture.Calendar;
                    break;

            }

            return calendar;

        }

    }

}
