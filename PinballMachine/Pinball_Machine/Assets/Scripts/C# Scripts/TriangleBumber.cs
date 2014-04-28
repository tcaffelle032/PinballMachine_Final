using UnityEngine;
using System.Collections;

public class TriangleBumber : MonoBehaviour
{

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}

		void OnTriggerEnter (Collider collider)
		{
				if (collider.name == "Pinball") {
						
						GameManager.ScoreUpdate (50);
						collider.rigidbody.AddForce (-this.transform.forward * .5f); 
						GameManager.PlayEffect(GameManager.AudioType.TriBounce);
				}

		}

}
