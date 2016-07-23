using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public int speed = 15000;
	public char lastKeyPressed;
	// Use this for initialization
	void Start () {
		lastKeyPressed = 'W';
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, speed) * Time.deltaTime;
			lastKeyPressed = 'W';
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, -speed) * Time.deltaTime;
			lastKeyPressed = 'S';
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (speed, 0) * Time.deltaTime;
			lastKeyPressed = 'D';
		} 
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-speed, 0) * Time.deltaTime;
			lastKeyPressed = 'A';
		}

	}
	public char getLastKeyPressed(){
		return lastKeyPressed;
	}
}
