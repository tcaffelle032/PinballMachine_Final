
using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

		PlayMusic();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnEnable(){
		GameManager.OnPlayEffect += PlaySound;
	}
	void OnDisable(){
		GameManager.OnPlayEffect -= PlaySound;
	}

	void PlaySound(GameManager.AudioType audioType){
		switch(audioType){
		case GameManager.AudioType.Bumper:
			AudioClip clip = Resources.Load("Sounds/Bell")as AudioClip;
			AudioSource.PlayClipAtPoint(clip,Vector3.zero);
			break;
		case GameManager.AudioType.Death:
			AudioClip DeathClip = Resources.Load("Sounds/Death")as AudioClip;
			AudioSource.PlayClipAtPoint(DeathClip,Vector3.zero);
			break;
		case GameManager.AudioType.Over:
			var temp = GameObject.Find("Manager").GetComponent<AudioSource>();
			Destroy(temp);
			AudioClip GameOverClip = Resources.Load("Sounds/GameOver")as AudioClip;
			AudioSource.PlayClipAtPoint(GameOverClip,Vector3.zero);
			GameManager.BallCount = 0;
			break;
		case GameManager.AudioType.TriBounce:
			AudioClip BumperClip = Resources.Load("Sounds/BumperBounce")as AudioClip;
			AudioSource.PlayClipAtPoint(BumperClip,Vector3.zero);
			break;
		}
	}
	public void PlayMusic(){ 
		var temp = GameObject.Find("Manager");
		temp.gameObject.AddComponent<AudioSource>();
		AudioClip music = Resources.Load("Sounds/BgMusic")as AudioClip;
		var AS = temp.gameObject.GetComponent<AudioSource>();
		AS.clip = music;
		AS.loop = true;
		AS.playOnAwake = true;
		AS.Play();

	}



}
