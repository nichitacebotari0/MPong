using Godot;

public class Wall : Area2D
{
	[Export]
	public Vector2 Normal { get; private set; }

	private void _on_Wall_area_entered(object area)
	{
		if (area is Ball ball)
		{
			GD.Print("direction: " + ball.Direction);
			var projetced = Normal.Dot(ball.Direction);
			GD.Print("projected: " + projetced);
			var scaled = projetced * Normal;
			GD.Print("scaled:    " + scaled);
			scaled *= 2;
			GD.Print("2x scaled: " + scaled);
			ball.Direction = ball.Direction - scaled;
		}
	}
}


