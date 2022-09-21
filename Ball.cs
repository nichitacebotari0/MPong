using Godot;
using System;

public class Ball : Area2D
{
	public Vector2 Direction;
	[Export]
	private int _speed = 400;

	private Vector2 _spawnLocation;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_spawnLocation = Position;
		Reset();
	}

	public override void _Process(float delta)
	{
		Position += Direction * _speed * delta;
	}

	public void Reset()
	{
		Direction = Vector2.Right;
		Position = _spawnLocation;
		_speed = 200;
	}
}
