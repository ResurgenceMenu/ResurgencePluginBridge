using System.Text;
using BepInEx;

namespace ResurgencePluginBridge;

[BepInPlugin(Constants.Guid, Constants.Name, Constants.Version)]
[BepInDependency("industry.resurgencev2")]
public class Plugin : BaseUnityPlugin
{
    // This class is only here so the mod actually loads.
}

public static class ExtensionFromCats
{
    // This is taken straight from Cats.
    public static string Spaced(this string input)
    {
        var result = new StringBuilder();
        for (int i = 0; i < input.Length; i++)
        {
            if (i > 0 && char.IsUpper(input[i]) &&
                (!char.IsUpper(input[i - 1]) || (i + 1 < input.Length && !char.IsUpper(input[i + 1]))))
                result.Append(' ');

            result.Append(input[i]);
        }

        return result.ToString();
    }
}