using System;

namespace Bb.Calendarium.Helpers
{

    internal class EasterBlock
    {

        public EasterBlock(int year)
        {
            GoodFriday = EasterHelper.EasterDate(year).AddDays(-2);
            EasterDate = EasterHelper.EasterDate(year);
            EasterMonday = EasterDate.Date.AddDays(1);
            PentecostSunday = EasterDate.Date.AddDays(49);
            WhitMonday = EasterDate.Date.AddDays(50);
            Ascension = EasterDate.Date.AddDays(39);
        }

        /// <summary>
        /// Vendredi saint
        /// </summary>
        public DateTime GoodFriday { get; }
        /// <summary>
        /// Date de pâcques
        /// </summary>
        public DateTime Ascension { get; }

        /// <summary>
        /// Date de pâcques
        /// </summary>
        public DateTime EasterDate { get; }

        /// <summary>
        /// Lundi de pâcques
        /// </summary>
        public DateTime EasterMonday { get; }

        /// <summary>
        /// Dimanche de Pentecôte
        /// </summary>
        public DateTime PentecostSunday { get; }

        /// <summary>
        /// Lundi de Pentecôte
        /// </summary>
        public DateTime WhitMonday { get; }

    }
}
