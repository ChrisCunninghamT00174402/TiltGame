using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

	public GameObject ball;
	private Vector3 offset;

	// Use this for initialization
	void Start () {
	
		offset = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.position = ball.transform.position + offset;
	}
}
