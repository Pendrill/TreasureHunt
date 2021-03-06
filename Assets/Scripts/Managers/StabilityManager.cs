﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class StabilityManager : MonoBehaviour {

	public int currentStability;
	public int maxStability;
	public int minStability;
	public int startingStability;
	public Text sanity;
	// Use this for initialization
	void Start () {
		currentStability = startingStability;
	}
	
	// Update is called once per frame
	void Update () {
		sanity.text = "Sanity:  " + currentStability + "%";
	}
	public void loseStability (int damage){
		currentStability -= damage;
		currentStability = Mathf.Clamp (currentStability, minStability, maxStability);
		if (currentStability <= 0) {
			SceneManager.LoadScene (3);
			//Same as with the health, we wouldn't want to actually destroy the object, but rather set off an animation that would then lead to the gameover screen.
		}

	}
	public void gainStability (int health){
		Debug.Log ("HI");
		currentStability += health;
		currentStability = Mathf.Clamp (currentStability, minStability, maxStability);
	}

	public int getStability(){
		return currentStability;
	}
	public void setStability(int stabilityValue){
		currentStability = stabilityValue;
	}
	public bool StabilityCheck(){
		if (currentStability <= 35) {
			return true;
		} else {
			return false;
		}

	}
}
