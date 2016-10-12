using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {


	public GameObject DestroyWall;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision coll){
		if (coll.gameObject.tag == "Button") {

			Destroy(DestroyWall.gameObject);
				}

		}


}
