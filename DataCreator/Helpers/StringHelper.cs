using System.Globalization;

namespace DataCreator.Library.Helpers
{
    public static class StringHelper
    {
        public static string FormatName(string name) => CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name.ToLower());
    }
}
