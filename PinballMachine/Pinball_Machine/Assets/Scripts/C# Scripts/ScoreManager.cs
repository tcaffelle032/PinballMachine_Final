using UnityEngine;
using System.Collections;



public class ScoreManager : MonoBehaviour {
	int score,highScore;

	// Use this for initialization
	void Start () {
		highScore = PlayerPrefs.GetInt("HighScore");
	}
	void OnEnable(){
		GameManager.OnUpdateScore += addScore;
	}
	
	void OnDisable(){
		GameManager.OnUpdateScore -= addScore;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnGUI(){
		GUI.Label(new Rect(0,0,100,50),"Score: " + Score);
		GUI.Label(new Rect(0,20,100,50),"High Score " + HighScore);
		if(GameManager.BallCount >=3)
			GUI.Label(new Rect(Screen.width/3*2,0,200,200),"Controls are: \n" +
				"'A' for Left Flipper \n " +
				"'D' for Right Flipper \n " +
				"'S' for Plunger \n " +
				"'R' to Respawn if you get stuck");
		GUI.Label(new Rect(Screen.width/4*3 ,0,200,200),"Lives: " + GameManager.BallCount);
	}
	

	public int Score{
		get{
			return score;
		}
		set{
			score += value;
		}
		
	}

	public int HighScore{
		get {return highScore;}
		set { highScore = value;}
	}

	void addScore(int scoreValue){
		Score = scoreValue;
		if(Score >= HighScore){
			HighScore = Score;
			PlayerPrefs.SetInt("HighScore",HighScore);
		}
	}
}
