# Resurgence Plugin Bridge

The Resurgence Plugin Bridge provides the public API used to
create plugins for Resurgence.

## Installation

Reference ResurgencePluginBridge.dll in your project.

## Creating a plugin

All plugins must inherit from Mod.

## Attributes

### PluginToggleable
Makes a plugin toggleable.

### PluginPreferenced
Persists the plugin's toggle state.

### PluginHideInVR
Prevents the plugin from loading in VR.

### PluginHideInDesktop
Prevents the plugin from loading on Desktop.

## Example

[code example]

## Project structure

Plugins MUST follow:

RootNamespace.Mods.CategoryName

## Unity lifecycle

Mod inherits from MonoBehaviour, so Unity lifecycle methods
such as Start and Update are available.

## Example project

See [ResurgencePlugin](https://github.com/ResurgenceMenu/ResurgencePlugin).
