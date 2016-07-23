using UnityEngine;
using System.Collections;

public class ShootBullet : MonoBehaviour {
	public Transform BulletSpawner;
	public GameObject Bullet;
	private float nextFire;
	public float fireRate;
	public GameObject player;
	char lastKey;
	int count=0;

	// Use this for initialization
	void Start () {
		lastKey = player.GetComponent<PlayerMovement> ().getLastKeyPressed ();
	}
	
	// Update is called once per frame
	void Update () {
		
		lastKey = player.GetComponent<PlayerMovement> ().getLastKeyPressed ();

		if (Input.GetKeyDown (KeyCode.Z)&& Time.time > nextFire) {
			count++;
			nextFire = Time.time + fireRate;
			if (lastKey == 'W') {
				//Debug.Log ("hi");
				Instantiate (Bullet, BulletSpawner.position+ new Vector3(0,30,0), BulletSpawner.rotation);
			}else if (lastKey == 'S') {
				Instantiate (Bullet, BulletSpawner.position+ new Vector3(0,-30,0), BulletSpawner.rotation);
			}else if (lastKey == 'D') {
				Instantiate (Bullet, BulletSpawner.position+ new Vector3(30,0,0), BulletSpawner.rotation);
			}else if (lastKey == 'A') {
				Instantiate (Bullet, BulletSpawner.position+ new Vector3(-30,0,0), BulletSpawner.rotation);
			}

			//Instantiate (Bullet, BulletSpawner.position, BulletSpawner.rotation);
		}
	}
}
