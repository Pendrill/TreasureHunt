using UnityEngine;
using System.Collections;

public class MoveBullet : MonoBehaviour {
	
	private char playerKey;
	private int count;
	public GameObject player;
	public Rigidbody2D RigidBodyBullet;
	public int bulletSpeed = 3000;

	// Use this for initialization
	void Start () {
		playerKey = player.GetComponent<PlayerMovement> ().getLastKeyPressed ();
		//Debug.Log ("hi");
		RigidBodyBullet = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		RigidBodyBullet.velocity = new Vector2 (0, 0);
		//Debug.Log (playerKey);
		if (playerKey == 'W') {
			//Debug.Log ("hi");
			RigidBodyBullet.velocity += new Vector2 (0, bulletSpeed) * Time.deltaTime;
		}else if (playerKey == 'S') {
			RigidBodyBullet.velocity += new Vector2 (0, -bulletSpeed) * Time.deltaTime;
		}else if (playerKey == 'D') {
			RigidBodyBullet.velocity += new Vector2 (bulletSpeed, 0) * Time.deltaTime;
		}else if (playerKey == 'A') {
			RigidBodyBullet.velocity += new Vector2 (-bulletSpeed, 0) * Time.deltaTime;
		}
	}
	void OnTriggerEnter2D(Collider2D Enemy){
		Debug.Log ("Hello");
		if (Enemy.GetComponent<Damager> () != null) {
			Destroy (Enemy.gameObject);
		}
	}


}
