using Godot;
using System;

public class Player : Area2D
{
	[Export]
	private int _speed = 200;

	[Export]
	private string _player = "player1";

	private string _action_up;
	private string _action_down;

	public override void _Ready()
	{
		_action_up = _player + "_up";
		_action_down = _player + "_down";
	}

	private void _on_Paddle1_area_entered(object area)
	{
		if (area is Ball ball)
		{
			var reflect = ball.Position - Position;
			ball.Direction = reflect.Normalized();
		}
	}

	public override void _Process(float delta)
	{
		Vector2 position = Position;
		if (Input.IsActionPressed(_action_up))
		{
			position += Vector2.Up * _speed * delta;

		}
		if (Input.IsActionPressed(_action_down))
		{
			position += Vector2.Down * _speed * delta;
		}
		position.y = Mathf.Clamp(position.y, 36, GetViewportRect().Size.y - 36);
		Position = position;
	}
}

