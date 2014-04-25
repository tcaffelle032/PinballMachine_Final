using UnityEngine;
using System.Collections;

public class UserInputs : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	void OnEnable(){
		GameManager.OnUserInput+= quitGame;
	}
	void OnDisable(){
		GameManager.OnUserInput-= quitGame;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.anyKey)
			GameManager.UpdateUserInput();
	}
	void quitGame(){
		if(Input.GetKeyDown(KeyCode.Escape))
			Application.Quit();
	}
}
