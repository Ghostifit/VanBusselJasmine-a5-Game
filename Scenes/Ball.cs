using Godot;
using System;

public partial class Ball : RigidBody2D
{
    [Export] Label ScoreLabel;
    public int score = 0;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
        BodyEntered += Ball_BodyEntered;
	}

    private void Ball_BodyEntered(Node body)
    {
        if (body.Name.ToString().Contains("StaticBody"))
        {
            /*
            GD.Print(body);
            */
            score += 1;
            GD.Print(score);
            ScoreLabel.Text = $"Score: {score}";
           
        }
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
	{
	}
}
