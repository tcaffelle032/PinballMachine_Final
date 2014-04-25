using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnEnable(){

	}
	void OnDisable(){

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
		if(collider.name == "Pinball"){
			this.renderer.material.color = new Color(0,0,0);
       	    collider.rigidbody.AddForce(collider.transform.forward);
			GameManager.ScoreUpdate(100);

			var colors = new ArrayList();

			colors.Add(Color.red);
			colors.Add(Color.blue);
			colors.Add(Color.green);
			colors.Add(Color.yellow);


			this.renderer.material.color = (Color)colors[Random.Range(0,4)];

			GameManager.PlayEffect(GameManager.AudioType.Bumper);
		
		

		}
    }
	void OnTriggerExit(Collider collider){
		if(collider.name == "Pinball"){
			this.renderer.material.color = Color.white;
		}
	}
}
