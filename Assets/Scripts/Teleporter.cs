using UnityEngine;
using System.Collections;

public class Teleporter : MonoBehaviour {

	//public GameObject teleportedObject;
	public int locationX;
	public int locationY;
	public int locationZ;

	void OnTriggerEnter2D (Collider2D player){
		player.GetComponent<Transform> ().position = new Vector3 (locationX, locationY, locationZ);
		//player.gameObject.transform.position = new Vector3 (locationX, locationY, locationZ);

	}
}
