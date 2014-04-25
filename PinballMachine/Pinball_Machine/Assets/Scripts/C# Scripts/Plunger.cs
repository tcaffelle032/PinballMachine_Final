using UnityEngine;
using System.Collections;

public class Plunger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnEnable(){
		GameManager.OnUserInput += pullPlunger;
	}
	void OnDisable(){
		GameManager.OnUserInput -=pullPlunger;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void pullPlunger(){
		if(Input.GetKeyDown(KeyCode.S))
		{
			var plunger = GameObject.Find("Plunger");
			
			plunger.transform.position += -plunger.transform.up *2;
		}

		if((Input.GetKeyDown(KeyCode.R))&& (GameManager.Gamestates == GameManager.GameState.Play)){
			GameManager.BallDestroyed();	
		}
		if((Input.GetKeyDown(KeyCode.R))&& (GameManager.Gamestates == GameManager.GameState.GameOver)){
			GameManager.Restarting();
		}

	}

}
