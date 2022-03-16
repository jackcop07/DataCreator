using DataCreator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataCreator.Models
{
    public class PropertyModel
    {
        public string Accessor { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public PropertyType PropertyEnum { get; set; }
    }
}
