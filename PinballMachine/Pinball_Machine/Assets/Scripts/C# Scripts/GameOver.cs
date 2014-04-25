using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnEnable(){
		GameManager.OnGameOver += GameEnd;
	}
	void OnDisable(){
		GameManager.OnGameOver -= GameEnd;
	}
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		var gamestate = GameManager.Gamestates;
		if(gamestate == GameManager.GameState.GameOver)
		{
			GUI.Box(new Rect(Screen.width/3,Screen.height/2,150,75),"GAME OVER!!\n Press 'R' to restart");
		}
	}

	void GameEnd(){
	

		GameManager.Gamestates = GameManager.GameState.GameOver;
		GameManager.PlayEffect(GameManager.AudioType.Over);
	}
}
