using Godot;
using System;

public class Label : Godot.Label
{

    public override void _Ready()
    {
        // Crashes
        this.Text = FSharpLib.Example.listOfStrings[0];
    }


}
