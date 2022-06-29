using System.Text.Json;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Unicode;

namespace Lab2;

public class JsonManager
{
    
    public static async void SerializeToJson<T>(T obj, string path)
    {
        await using FileStream fs = File.Create(path);
        await JsonSerializer.SerializeAsync(fs, obj);
        await fs.DisposeAsync();
    }
    
    public static T DeserializeFormJson<T>(string path)
    {
        if (!File.Exists(path))
        {
            throw new Exception("file does not exist");
        }
        using FileStream fs = File.OpenRead(path);
        var obj = JsonSerializer.Deserialize<T>(fs);
        return obj;
    }
}