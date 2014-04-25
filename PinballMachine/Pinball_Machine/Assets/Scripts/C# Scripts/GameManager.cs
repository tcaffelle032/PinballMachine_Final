using UnityEngine;
using System.Collections;

public static class GameManager
{
	//Comment
    /// <summary>
    /// Overall Game Manager, here are public variables
    /// that can be used by all classes such as the score
    /// and the number of lives the player has.
    /// Also included in theis class are the events that 
    /// are used throughout the program
    /// </summary>

	public static int BallCount =3;
	public static ScoreManager score = GameObject.Find("Manager").GetComponent<ScoreManager>();
	public static AudioManager m_Audio = GameObject.Find("Manager").GetComponent<AudioManager>();

	public  enum GameState{Play,GameOver};
	public static GameState Gamestates;

	public enum AudioType{Bumper,Death,Over,TriBounce};

    public delegate void BallDestroy();
    public static event BallDestroy OnBallDestroy;
    public static void BallDestroyed()
    {
        if (OnBallDestroy != null)
            OnBallDestroy();
    }

	public delegate void UpdateScore(int scoreValue);
	public static event UpdateScore OnUpdateScore;
	public static void ScoreUpdate(int score){
		if(OnUpdateScore!= null)
			OnUpdateScore(score);
	}

	public delegate void UserInput();
	public static event UserInput OnUserInput;
	public static void UpdateUserInput(){
		if(OnUserInput != null)
			OnUserInput();
	}

	public delegate void GameOverEnding();
	public static event GameOverEnding OnGameOver;
	public static void GameEnded(){
		if(OnGameOver != null)
			OnGameOver();
	}

	public delegate void Reset();
	public static event Reset OnGameReset;
	public static void Restarting(){
		if(OnGameReset != null)
			OnGameReset();
	}

	public delegate void PlaySounEffect(AudioType audioType);
	public static event PlaySounEffect OnPlayEffect;
	public static void PlayEffect(AudioType audioType){
		if(OnPlayEffect !=null)
			OnPlayEffect(audioType);
	}





}
