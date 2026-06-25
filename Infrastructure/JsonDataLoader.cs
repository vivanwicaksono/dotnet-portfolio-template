using System.Text.Json;

namespace VivanPortfolio.Infrastructure;

public static class JsonDataLoader
{
    private static readonly JsonSerializerOptions Options = new()
    {
        PropertyNameCaseInsensitive = true
    };

    public static T Load<T>(string fileName, string subFolder = "JsonData")
    {
        var path = Path.Combine(AppContext.BaseDirectory, "Resources", subFolder, fileName);
        var json = File.ReadAllText(path);
        return JsonSerializer.Deserialize<T>(json, Options)!;
    }
}
