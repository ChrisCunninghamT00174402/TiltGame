using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float Speed = 2.0F;
	public float tiltAngle = 30.0F;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		float tiltAroundy = Input.GetAxis("Horizontal") * tiltAngle;
		float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;
		Quaternion target = Quaternion.Euler(tiltAroundX, 0, tiltAroundy);
		transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * Speed);


	}
}
