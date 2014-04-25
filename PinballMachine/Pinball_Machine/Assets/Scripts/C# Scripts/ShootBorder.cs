using UnityEngine;
using System.Collections;

public class ShootBorder : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.OnBallDestroy += resetBlock;
	}


	// Update is called once per frame
	void Update () {
	
	}
	void OnEnabled(){

	}
	void OnDisable(){
		GameManager.OnBallDestroy -= resetBlock;
	}

	void OnTriggerExit(){
		this.collider.isTrigger = false;
		this.renderer.enabled = true;
		if(collider.name =="Pinball"){
			StartCoroutine("addForce",1);
		}
	}

	void resetBlock(){
		this.collider.isTrigger = true;
		this.renderer.enabled = false;
	}

	void addForce(){	
		collider.rigidbody.AddForce(this.transform.forward * 10);
	}
}
