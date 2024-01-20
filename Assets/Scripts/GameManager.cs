using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public bool gameStarted;
	public int score = 0;
	public int highScore;
	public Text scoreText;
	public Text highScoreText;

	public void Awake()
	{
		highScoreText.text = GetHighScore().ToString();
	}


	public void StartGame()
	{
		 this.gameStarted = true;
		FindObjectOfType<Road>().StartBuilding();
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			StartGame();
		}
	}

	public void EndGame()
	{
		SceneManager.LoadScene(0);
	}

	public void IncrScore()
	{
		this.score++;
        scoreText.text = score.ToString();
		if (score>  GetHighScore())
		{
			PlayerPrefs.SetInt("highScore", score);
			highScoreText.text = highScore.ToString();
		}
    }

	public int GetHighScore()
	{
		int i = PlayerPrefs.GetInt("highScore");
		return i;
	}
}
