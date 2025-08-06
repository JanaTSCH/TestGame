using Godot;
using System;

public partial class Main : Node2D
{
	public override void _Ready()
	{
		TestMethod();
		GD.Print("Hello World");
	}

	public override void _Process(double delta)
	{
	}
	private void TestMethod()
	{
		GD.Print("entered test method");	
	}
}
