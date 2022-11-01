using System.Globalization;

namespace Demo_on_Razor_Syntax.Helpers
{
	public class StringUtilityExtensions
	{
        public static string ToTitleCase(string value)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            return textInfo.ToTitleCase(value.ToLower());
        }
    }
}
