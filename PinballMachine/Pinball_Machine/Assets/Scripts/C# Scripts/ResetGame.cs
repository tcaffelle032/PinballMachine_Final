using UnityEngine;
using System.Collections;

public class ResetGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable(){
		GameManager.OnGameReset += RestartGame;
	}
	void OnDisable(){
	GameManager.OnGameReset -= RestartGame;
		
	}

	void RestartGame(){
		var score = GameManager.score.Score;
		GameManager.Gamestates = GameManager.GameState.Play;
		GameManager.ScoreUpdate(-score);
		GameManager.BallDestroyed();
		GameManager.BallCount = 3;
		GameManager.m_Audio.PlayMusic();



	}
}
