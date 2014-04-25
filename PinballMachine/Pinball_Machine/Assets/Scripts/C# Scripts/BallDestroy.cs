using UnityEngine;
using System.Collections;

public class BallDestroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    
	}
    void OnEnable()
    {
        GameManager.OnBallDestroy += removeBall;
    }

    void OnDisable()
    {
        GameManager.OnBallDestroy -= removeBall;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider collider)
    {
		if(collider.gameObject.name =="Pinball"){
			GameManager.BallCount--;
        GameManager.BallDestroyed(); //Triggers the Ball destroyed event. All subscribed events are told to do what is needed.
		
		}
    }

    void removeBall()
    {
		if(GameManager.Gamestates == GameManager.GameState.Play){
       	 GameObject temp = GameObject.Find("Pinball");
        	Destroy(temp);
			GameManager.PlayEffect(GameManager.AudioType.Death);
		}

    }

   
}
