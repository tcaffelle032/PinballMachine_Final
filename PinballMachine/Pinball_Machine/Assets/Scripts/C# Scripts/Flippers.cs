using UnityEngine;
using System.Collections;

public  class Flippers: MonoBehaviour
{
    static float ForceAmount = 1000f;
    //public static KeyCode Right, Left;
    /// <summary>
    /// Input handeled for the flippers. Used
    /// a static manager so it is created at run-time 
    /// and doesn't need an in game object.
    /// </summary>
    public void FlipperControl() 
    {

        /* var joint = LFlipper.hingeJoint;
         joint.axis = new Vector3(0, -1, 0);
        joint.anchor = new Vector3(0, 0.5f, 0.6f);

         joint.useSpring = true;

         joint.spring.spring.Equals(50);
         joint.limits.min.Equals(-45);   */

        GameObject LFlipper = GameObject.Find("LFlipper");
        GameObject RFlipper = GameObject.Find("RFlipper");


        if (Input.GetKey(KeyCode.D))
        {
            LFlipper.rigidbody.AddForce(-LFlipper.transform.right * ForceAmount, ForceMode.Acceleration);
            LFlipper.rigidbody.useGravity = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            RFlipper.rigidbody.AddForce(-RFlipper.transform.right * ForceAmount, ForceMode.Acceleration);
            RFlipper.rigidbody.useGravity = true;
        }
       
    }

	void OnEnable(){
		GameManager.OnUserInput += FlipperControl;
	}
	void OnDisable(){
		GameManager.OnUserInput -= FlipperControl;
	}
}
