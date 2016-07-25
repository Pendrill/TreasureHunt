using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public int speed = 15000;
	public char lastKeyPressed;
	public AudioSource walking;
	// Use this for initialization
	void Start () {
		lastKeyPressed = 'W';
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, 0);

		if (Input.GetKey (KeyCode.W) || Input.GetKey (KeyCode.UpArrow)) {
			if (!walking.isPlaying) {
				walking.PlayOneShot (walking.clip);
			}
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, speed) * Time.deltaTime;
			lastKeyPressed = 'W';
		}
		if (Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.DownArrow)) {
			if (!walking.isPlaying) {
				walking.PlayOneShot (walking.clip);
			}
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (0, -speed) * Time.deltaTime;
			lastKeyPressed = 'S';
		}
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			if (!walking.isPlaying) {
				walking.PlayOneShot (walking.clip);
			}
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (speed, 0) * Time.deltaTime;
			lastKeyPressed = 'D';
		} 
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			if (!walking.isPlaying) {
				walking.PlayOneShot (walking.clip);
			}
			GetComponent<Rigidbody2D> ().velocity += new Vector2 (-speed, 0) * Time.deltaTime;
			lastKeyPressed = 'A';
		}

	}
	public char getLastKeyPressed(){
		return lastKeyPressed;
	}
}
