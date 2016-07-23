using UnityEngine;
using System.Collections;

public class MoveTowards : MonoBehaviour {

	public Transform player;
	float speed;

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("PC").transform;
		speed = Random.Range (50, 350);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		float step = speed*Time.deltaTime;
		transform.position = Vector3.MoveTowards (transform.position, player.position, step);

	}

}
