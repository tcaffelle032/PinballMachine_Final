using UnityEngine;
using System.Collections;

public class BallRespawn : MonoBehaviour {
	public float spawnZ,spawnY,spawnX;

   // public GameObject Pinball;
	// Use this for initialization
	void Start () {
		respawn();

	}
	
	void OnEnable(){
		GameManager.OnBallDestroy += respawn;

	}
	void OnDisable(){
		GameManager.OnBallDestroy -= respawn;
	}
	
	// Update is called once per frame
	void Update () {

	}

    void respawn()
    {
		if(GameManager.BallCount >=0 && GameManager.Gamestates == GameManager.GameState.Play){
		var plunger = GameObject.Find("Plunger");
		float rightPos = plunger.transform.forward.z *spawnZ;
		float upPos = plunger.transform.up.y*spawnY;
		
		

		var pinball = GameObject.Instantiate(Resources.Load("Pinball"),new Vector3(spawnX,upPos,rightPos),new Quaternion(0,0,0,0));
			pinball.name = "Pinball";


		}
		else GameManager.GameEnded();
        
    }


}
