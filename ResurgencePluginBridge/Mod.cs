using System;
using System.Reflection;
using ResurgencePluginBridge.Attributes;
using UnityEngine;

namespace ResurgencePluginBridge;

// This is a variant of the Mod class from cats, the menu Resurgence is using as a base.
public abstract class Mod : MonoBehaviour
{
    public string Name;
    public bool isToggle;
    public bool Preferenced;

    protected Mod() => InitializeMod();

    private void InitializeMod()
    {
        Name ??= GetType().Name.Spaced();
        if (GetType().GetCustomAttribute<PluginToggleable>() != null)
            isToggle = true;

        enabled = false;
        if (GetType().GetCustomAttribute<PluginPreferenced>() != null)
            Preferenced = true;
    }

    public virtual void Execute()
    {
    }
}