namespace MauiCustomWebView.Helpers;

public static class ResourceLoader
{
    public static string GetEmbeddedResourceString(string resourceName)
    {
        var assembly = typeof(ResourceLoader).Assembly;
        
        using var stream = assembly.GetManifestResourceStream(resourceName);

        if (stream == null)
        {
            throw new InvalidOperationException($"Resource {resourceName} not found.");
        }

        using var reader = new StreamReader(stream);

        return reader.ReadToEnd();
    }
}