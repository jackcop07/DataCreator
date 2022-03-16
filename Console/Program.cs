
using Console;
using DataCreator.Enums;
using DataCreator.Models;
using System.Dynamic;
using System.Text.Json;


var properties = new List<PropertyModel>()
{
    new()
    {
        Accessor = "Public",
        Type = "String",
        Name = "FirstName",
        PropertyEnum = PropertyType.FirstName
    },
    new()
    {
        Accessor = "Public",
        Type = "String",
        Name = "LastName",
        PropertyEnum = PropertyType.LastName
    },
    new()
    {
        Accessor = "Public",
        Type = "String",
        Name = "Age",
        PropertyEnum = PropertyType.Age
    },
    new()
    {
        Accessor = "Public",
        Type = "DateTime",
        Name = "StartDate",
        PropertyEnum= PropertyType.DOB
    },
    new()
    {
        Accessor = "Public",
        Type = "Int",
        Name = "Id",
        PropertyEnum = PropertyType.IntId
    },
    new()
    {
        Accessor = "Public",
        Type = "GUID",
        Name = "GuidId",
        PropertyEnum = PropertyType.GUID
    }
};


var dataService = new DataService();

var result = dataService.CreateData(10, properties);


var json = JsonSerializer.Serialize(result);


System.Console.ReadLine();
