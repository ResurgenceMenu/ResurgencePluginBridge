using System;

namespace ResurgencePluginBridge.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginHideInDesktop : Attribute // As the name suggests, this makes the mod not load on Desktop.
    {
    }
}
