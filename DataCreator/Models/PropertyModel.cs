using DataCreator.Library.Enums;

namespace DataCreator.Library.Models
{
    public class PropertyModel
    {
        public string Accessor { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public PropertyType PropertyEnum { get; set; }
    }
}
