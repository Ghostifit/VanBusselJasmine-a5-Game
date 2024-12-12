using Godot;
using System;

public partial class Paddle : Node2D
{
	float PaddleSpeed;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        
    }

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		
		float Movement = Input.GetAxis("Left", "Right");
		float Change = Movement * PaddleSpeed *(float)delta;

		Vector2 newPosition = new Vector2(Position.X + Change, Position.Y );

		Position = newPosition;
    }
}
