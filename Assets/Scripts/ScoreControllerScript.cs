using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreControllerScript : MonoBehaviour {

	private int scorePlayer1 = 0;
	private int scorePlayer2 = 0;

	public GameObject scoreTextPlayer1;
	public GameObject scoreTextPlayer2;

	public int goalToWin;

	public void MoveToScene(int scene)
	{
		SceneManager.LoadScene(scene);
	}

	// Update is called once per frame
	void Update () {
		if (this.scorePlayer1 >= goalToWin || this.scorePlayer2 >= goalToWin)
		{
			Debug.Log("game won!!");
			MoveToScene(3);
		}
	}

	void FixedUpdate()
	{
		Text uiScorePlayer1 = this.scoreTextPlayer1.GetComponent<Text>();
		uiScorePlayer1.text = this.scorePlayer1.ToString();

		Text uiScorePlayer2 = this.scoreTextPlayer2.GetComponent<Text>();
		uiScorePlayer2.text = this.scorePlayer2.ToString();
	}

	public void GoalPlayer1()
	{
		this.scorePlayer1++;
	}

	public void GoalPlayer2()
	{
		this.scorePlayer2++;
	}
}
