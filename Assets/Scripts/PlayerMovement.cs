using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public int speed = 15000;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

		if (Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, speed) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-speed, 0) * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (speed, 0) * Time.deltaTime;
		} 
		if (Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, -speed) * Time.deltaTime;
		}

	}
}
