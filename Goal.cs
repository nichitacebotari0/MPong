using Godot;
using System;

public class Goal : Area2D
{
	[Export]
	private int _team;

	private void _on_Goal_area_entered(object area)
	{
		// TODO: increment score of player
		
		// Reset ball position
		if (area is Ball ball)
		{
			ball.Reset();
		}
	}

}
