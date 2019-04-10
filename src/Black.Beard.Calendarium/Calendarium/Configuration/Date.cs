using System;
using System.Globalization;

namespace Bb.Calendarium.Configuration
{

    public class Date : ICloneable
    {

        public Date(DateTime originalDate, Calendar originalCalendar, Calendar referentialCalendar)
        {
            OriginalDate = originalDate;
            OriginalCalendar = originalCalendar;
            ReferentialCalendar = referentialCalendar;
        }

        public DateTime OriginalDate { get; }

        public Calendar OriginalCalendar { get; }

        public Calendar ReferentialCalendar { get; }

        public int OriginalYear => OriginalCalendar.GetYear(OriginalDate);

        /// <summary>
        /// Gets month of the year in the referential calendar.
        /// </summary>
        /// <value>
        /// The originald month.
        /// </value>
        public int OriginaldMonth => OriginalCalendar.GetMonth(OriginalDate);

        public int OriginalDayOfMonth => OriginalCalendar.GetDayOfMonth(OriginalDate);

        public int ReferentialYear => ReferentialCalendar.GetYear(OriginalDate);

        /// <summary>
        /// Gets month of the year in the referential calendar.
        /// </summary>
        /// <value>
        /// The referential month.
        /// </value>
        public int ReferentialMonth => ReferentialCalendar.GetMonth(OriginalDate);

        /// <summary>
        /// Gets the day position in the month translated in the referential caldendar.
        /// </summary>
        /// <value>
        /// The referential day of month.
        /// </value>
        public int ReferentialDayOfMonth => ReferentialCalendar.GetDayOfMonth(OriginalDate);

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        public object Clone()
        {
            return new Date(OriginalDate, OriginalCalendar, ReferentialCalendar);
        }

        /// <summary>
        /// Converts the value of the current System.DateTime object to its equivalent string
        /// representation using the specified format and culture-specific format information.
        /// </summary>
        /// <param name="format">A standard or custom date and time format string..</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A <see cref="System.String" /> representation of value of the current System.DateTime object as specified by format and provider.
        /// </returns>
        /// <exception cref="System.FormatException">
        /// The length of format is 1, and it is not one of the format specifier characters defined for System.Globalization.DateTimeFormatInfo. -or- format does not contain a valid custom format pattern.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The date and time is outside the range of dates supported by the calendar used by provider.
        /// </exception>
        public string ToString(string format, IFormatProvider provider)
        {
            return OriginalDate.ToString(format, provider);
        }

        /// <summary>
        /// Converts the value of the current System.DateTime object to its equivalent string
        ///     representation using the specified format and culture-specific format information.
        /// </summary>        
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>
        /// A <see cref="System.String" /> representation of value of the current System.DateTime object as specified by format and provider.
        /// </returns>
        /// <exception cref="System.FormatException">
        /// The length of format is 1, and it is not one of the format specifier characters defined for System.Globalization.DateTimeFormatInfo. -or- format does not contain a valid custom format pattern.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The date and time is outside the range of dates supported by the calendar used by provider.
        /// </exception>
        public string ToString(IFormatProvider provider)
        {
            return OriginalDate.ToString(provider);
        }

        /// <summary>
        /// Converts the value of the current System.DateTime object to its equivalent string
        ///     representation using the specified format and culture-specific format information.
        /// </summary>
        /// <param name="format">A standard or custom date and time format string..</param>
        /// <returns>
        /// A <see cref="System.String" /> representation of value of the current System.DateTime object as specified by format and provider.
        /// </returns>
        /// <exception cref="System.FormatException">
        /// The length of format is 1, and it is not one of the format specifier characters defined for System.Globalization.DateTimeFormatInfo. -or- format does not contain a valid custom format pattern.
        /// </exception>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// The date and time is outside the range of dates supported by the calendar used by provider.
        /// </exception>
        public string ToString(string format)
        {
            return OriginalDate.ToString(format);
        }

        /// <summary>
        /// Returns a new System.DateTime that adds the specified number of days to the value
        ///     of this instance.
        /// </summary>
        /// <param name="day">A number of whole and fractional days. The value parameter can be negative or
        ///     positive.</param>
        /// <returns>
        /// An object whose value is the sum of the date and time represented by this instance
        /// and the number of days represented by value.
        /// </returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// The resulting System.DateTime is less than System.DateTime.MinValue or greater than System.DateTime.MaxValue.
        /// </exception>
        public Date AddDay(double day)
        {
            return new Date(OriginalDate.AddDays(day), OriginalCalendar, ReferentialCalendar);
        }

        public static bool operator ==(Date left, Date right)
        {
            return left.OriginalDate == right.OriginalDate;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Date left, Date right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator ==(Date left, DateTime right)
        {
            return left.Equals(right);
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>
        /// The result of the operator.
        /// </returns>
        public static bool operator !=(Date left, DateTime right)
        {
            return !left.Equals(right);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {

            if (obj == null)
                return false;

            if (obj is Date d)
                return OriginalDate.Equals(d.OriginalDate);

            return false;

        }

        public override int GetHashCode()
        {
            return OriginalDate.GetHashCode();
        }

    }

}
