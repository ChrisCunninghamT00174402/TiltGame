using UnityEngine;
using System.Collections;
#pragma warning disable 0414

public class BallSpawn : MonoBehaviour {
	 
	public GameObject Enemyspawn;
	GameObject EnemySpawnClone; 
			


	// Use this for initialization
	void Start () {

		EnemySpawnClone = Instantiate (Enemyspawn, transform.position, Quaternion.identity) as GameObject;

	}
	
	// Update is called once per frame
	void Update () {
	
	}



}
