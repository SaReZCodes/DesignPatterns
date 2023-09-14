using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

public static class ExtensionMethod
{
    public static T DeepCopy<T>(this T t)
    {
        var json = JsonSerializer.Serialize(t);
        return JsonSerializer.Deserialize<T>(json);
    }
}