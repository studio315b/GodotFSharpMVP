# Godot F# issue MVP

When developing with .net 5.0, Godot crashes if there are lists in the F# code.
I'm pretty sure it's a generalized issue, but this is how I found it.

## Repro Steps

Open `GodotGame` in godot and attempt to run it

## Expected outcome

A label with the text "one"

## Actual

Godot crashes with the error:

```
Unhandled Exception:
System.IO.FileNotFoundException: Could not load file or assembly 'FSharp.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a' or one of its dependencies.
File name: 'FSharp.Core, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a'
```

## Validation

CSharpApp is a .net 5.0 console app that also reads from the FSharpLib. Running `dotnet run` from the CSharpApp folder should result in "one" being printed.
This indicates that F# is loading as expected on this machine.
