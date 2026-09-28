using System;

namespace ResurgencePluginBridge.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginPreferenced : Attribute // This makes the mod save its toggled status.
    {
    }
}
