using System.Text.Json.Serialization;

namespace TaskManagerAPI.Models;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum TaskType
{
    Work,
    School,
    Personal,
    Shopping,
    House,
    Others
}