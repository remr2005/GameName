using Godot;
using System;

public partial class BACK : Button
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		this.Pressed +=  pressed;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	private void pressed()
	{
		GetTree().ChangeSceneToFile("res://tscens/menu/MENU.tscn");	
	}
}
