using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {

	private bool Right = true;
	public float speed = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Right) {

						transform.Translate (Vector2.right * speed * Time.deltaTime);
				} 
		else {
						transform.Translate (-Vector2.right * speed * Time.deltaTime);
				}

			if(transform.position.x >= 5.7f){
				Right = false;
				}
			if(transform.position.x <= 2.5f){
				Right = true;
			}
	
	}


}