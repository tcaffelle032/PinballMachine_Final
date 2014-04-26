using UnityEngine;
using System.Collections;

public class ScorePanel : MonoBehaviour {
	public int Points;
	// Use this for initialization
	void Start () {
		this.renderer.material.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider collider){
		if(collider.name =="Pinball"){
			GameManager.ScoreUpdate(Points);
			this.renderer.material.color = new Color(255/255.0f,142/255.0f,0/255.0f,255/255.0f);

		}
	}
	void OnTriggerExit(Collider collider){
		if(collider.name =="Pinball"){

			this.renderer.material.color = Color.yellow;
			
		}
	}
}
