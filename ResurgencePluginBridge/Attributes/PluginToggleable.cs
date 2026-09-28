using System;

namespace ResurgencePluginBridge.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginToggleable : Attribute // This makes the mod actually toggleable, as the name suggests.
    {
    }
}