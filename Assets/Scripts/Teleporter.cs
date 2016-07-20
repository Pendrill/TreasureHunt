using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	//public GameObject teleportedObject;
	public int locationX;
	public int locationY;
	public int locationZ;

	void OnTriggerEnter2D (Collider2D player){
		//player.GetComponent<Transform> ().position = new Vector3 (locationX, locationY, locationZ);
		player.gameObject.transform.position = new Vector3 (locationX, locationY, locationZ);
	}
	//TODO: Implement a way to sey everything within the scene that is not usefull to false, as a means to says power or whatever. I feel like that would be a good thing to do in general.
}
