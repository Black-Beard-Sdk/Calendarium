using System.Runtime.Serialization;

namespace Bb.Calendarium.Configuration
{
    /// <summary>
    /// Language's list available in the reference database
    /// </summary>
    /// <remarks>
    /// this the table CONFIG.LANGUAGE in the database
    /// </remarks>
    public enum Language : int
    {


        /// <summary>
        /// Undefined language
        /// </summary>
        Undefined = 0,

        /// <summary>
        /// French
        /// </summary>
        //[EnumMember(Value = "FR")]
        French,

        /// <summary>
        /// German
        /// </summary>
        //[EnumMember(Value = "DE")]
        German,

        /// <summary>
        /// English
        /// </summary>
        //[EnumMember(Value = "EN")]
        English,

        /// <summary>
        /// Dutch
        /// </summary>
        //[EnumMember(Value = "NL")]
        Dutch,

        /// <summary>
        /// Italian
        /// </summary>
        //[EnumMember(Value = "IT")]
        Italian,

        /// <summary>
        /// Estonian
        /// </summary>
        //[EnumMember(Value = "ET")]
        Estonian,

        /// <summary>
        /// Latvian
        /// </summary>
        //[EnumMember(Value = "LV")]
        Latvian,

        /// <summary>
        /// Lithuanian
        /// </summary>
        //[EnumMember(Value = "LT")]
        Lithuanian,

        /// <summary>
        /// Spanish
        /// </summary>
        //[EnumMember(Value = "ES")]
        Spanish,

        /// <summary>
        /// Romania
        /// </summary>
        //[EnumMember(Value = "RO")]
        Romania,

        /// <summary>
        /// Slovakia
        /// </summary>
        //[EnumMember(Value = "SK")]
        Slovak,

        /// <summary>
        /// Slovenian
        /// </summary>
        //[EnumMember(Value = "SI")]
        Slovenian,

        /// <summary>
        /// Croatian
        /// </summary>
        //[EnumMember(Value = "HR")]
        Croatian,

        /// <summary>
        /// Czech
        /// </summary>
        //[EnumMember(Value = "CS")]
        Czech,

        /// <summary>
        /// Polish
        /// </summary>
        [EnumMember(Value = "PL")]
        Polish,

        /// <summary>
        /// Hungarian
        /// </summary>
        //[EnumMember(Value = "HU")]
        Hungarian,

        /// <summary>
        /// Portuguese
        /// </summary>
        //[EnumMember(Value = "PT")]
        Portuguese,

        /// <summary>
        /// Russian
        /// </summary>
        //[EnumMember(Value = "RU")]
        Russian

    }

}
