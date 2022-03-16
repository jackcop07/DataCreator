using System.Globalization;

namespace DataCreator.Helpers
{
    public static class StringHelper
    {
        public static string FormatName(string name) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
    }
}
