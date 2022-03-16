using FileHelpers;

namespace DataCreator.Models
{
    [DelimitedRecord(",")]
    public class NameModel
    {
        public string Name { get; set; }
    }
}
