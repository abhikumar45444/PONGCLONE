using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController1Script : MonoBehaviour {

	public BallMovement ballMovement;
	public ScoreControllerScript1 scoreController;

	void BounceFromRacket(Collision2D col)
	{
		Vector3 ballPosition = this.transform.position;
		Vector3 racketPosition = col.gameObject.transform.position;

		float racketHeight = col.collider.bounds.size.y;

		float x;
		if (col.gameObject.name == "RacketPlayer1")
			x = 1;
		else
			x = -1;

		float y = (ballPosition.y - racketPosition.y) / racketHeight;

		this.ballMovement.IncreaseHitCounter();
		this.ballMovement.MoveBall(new Vector2(x, y));

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.name == "RacketPlayer1" || col.gameObject.name == "RacketPlayer2")
		{
			this.BounceFromRacket(col);
		}
		else if (col.gameObject.name == "WallLeft")
		{
			Debug.Log("Collsion with wallLeft");
			this.scoreController.GoalPlayer2();
			StartCoroutine(this.ballMovement.StartBall(true));
		}
		else if (col.gameObject.name == "WallRight")
		{
			Debug.Log("Collsion with wallRight");
			this.scoreController.GoalPlayer1();
			StartCoroutine(this.ballMovement.StartBall(false));
		}
	}
}
