using FileHelpers;

namespace DataCreator.Library.Models
{
    [DelimitedRecord(",")]
    public class NameModel
    {
        public string Name { get; set; }
    }
}
