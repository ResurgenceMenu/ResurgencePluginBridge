using System;

namespace ResurgencePluginBridge.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginHideInVR : Attribute // As the name suggests, this makes the mod not load in VR.
    {
    }
}
