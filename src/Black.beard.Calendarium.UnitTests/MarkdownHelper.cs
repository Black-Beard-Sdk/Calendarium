using System.Text;

namespace Bb.Calendarium.UnitTests
{

    public enum Mark
    {
        H1,
        H2,
        H3,
        H4,
        H5,
        H6,

        italic,
        Bold,
        Strikethrough,

    }

    public static class MarkdownHelper
    {

        public static StringBuilder MarkHorizontalRule(this StringBuilder self)
        {
            self.AppendLine("---");
            return self;
        }

        public static string MarkOrderedList(this string text, int level, int num)
        {
            return num.ToString().PadLeft(level, '.') + " " + text;
        }

        public static string MarkImage(this string altText, int imageUri)
        {
            return $"![alt text]({imageUri} \"{altText}\")";
        }

        public static string MarkList(this string text, int level)
        {
            return (text + " ").PadLeft(level, '.');
        }

        public static string MarkLink(this string text, string link)
        {
            return "[{text}]({kink})";
        }

        public static string MarkPython(string[] text)
        {
            return MarkCode(text, "python");
        }

        public static string MarkJavascript(string[] text)
        {
            return MarkCode(text, "javascript");
        }

        public static string MarkCode(string[] text, string language)
        {
            StringBuilder sb = new StringBuilder(1000);

            sb.Append(codeDelimiter);
            if (!string.IsNullOrEmpty(language))
                sb.Append(language);

            foreach (var item in text)
                sb.Append(item);

            sb.AppendLine(codeDelimiter);

            return sb.ToString();
        }

        public static string Mark(this string text, Mark mark)
        {

            switch (mark)
            {
                case UnitTests.Mark.H1:
                    return $"# {text}";
                case UnitTests.Mark.H2:
                    return $"## {text}";
                case UnitTests.Mark.H3:
                    return $"### {text}";
                case UnitTests.Mark.H4:
                    return $"#### {text}";
                case UnitTests.Mark.H5:
                    return $"##### {text}";
                case UnitTests.Mark.H6:
                    return $"###### {text}";
                case UnitTests.Mark.italic:
                    return $"_{text}_";
                case UnitTests.Mark.Bold:
                    return $"**{text}**";
                case UnitTests.Mark.Strikethrough:
                    return $"~~{text}~~";
                default:
                    System.Diagnostics.Debugger.Break();
                    break;
            }

            return text;

        }

        public static StringBuilder Mark(this StringBuilder self, Mark mark, string text)
        {
            self.Append(text.Mark(mark));
            return self;

        }

        public static StringBuilder MarkLine(this StringBuilder self, Mark mark, string text)
        {
            self.AppendLine(text.Mark(mark));
            return self;
        }

        private const string codeDelimiter = "```";

    }

}