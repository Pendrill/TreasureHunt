using UnityEngine;
using System.Collections;

public class Position : MonoBehaviour {

	public float getPositionX(){
		return GetComponent<Transform> ().position.x;
	}
	public float getPositionY(){
		return GetComponent<Transform> ().position.y;
	}
	public float getPositionZ(){
		return GetComponent<Transform> ().position.z;
	}
}
