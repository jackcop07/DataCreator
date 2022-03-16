using DataCreator.Enums;
using DataCreator.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class DataService
    {
        public List<IDictionary<string, Object>> CreateData(int collectionSize, List<PropertyModel> properties)
        {
            var generatedData = new List<IDictionary<string, Object>>();

            for (int i = 0; i < collectionSize; i++)
            {
                generatedData.Add(new ExpandoObject() as IDictionary<string, Object>);

                for (int j = 0; j < properties.Count; j++)
                {
                    generatedData[i].Add(properties[j].Name, GenerateData(properties[j].PropertyEnum));
                }
            }

            return generatedData;
        }


        private Object GenerateData(PropertyType dataType)
        {
            switch (dataType)
            {
                case PropertyType.FirstName:
                    return GetFirstName();
                case PropertyType.LastName:
                    return GetLastName();
                case PropertyType.Age:
                    return GetAge();
                case PropertyType.DOB:
                    return GetDOB();
                case PropertyType.IntId:
                    return GetIntId();
                case PropertyType.GUID:
                    return GetGuid();
                default:
                    return string.Empty;
            }
            return null;
        }

        private string GetFirstName()
        {
            var stringService = new NameRepository();

            return stringService.GetFirstName();
        }

        private string GetLastName()
        {
            var stringService = new NameRepository();

            return stringService.GetLastName();
        }

        private int GetAge()
        {
            var numberService = new NumberService();

            return numberService.GetAge();
        }

        private DateTime GetDOB()
        {
            var dateService = new DateService();

            return dateService.GetDate();
        }

        private int GetIntId()
        {
            var numberService = new NumberService();

            return numberService.GetId();
        }

        private Guid GetGuid()
        {
            var guidService = new GuidService();

            return guidService.GetGuid();
        }
    }
}
