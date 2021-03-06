﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour {

	public int currentHealth;
	public int maxHealth;
	public int minHealth;
	public int startingHealth;
	public Text Health;

	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		Health.text = "Health: " + currentHealth + "%";
	}
	public void DamageDone(int damage){
		currentHealth -= damage;
		currentHealth = Mathf.Clamp (currentHealth, minHealth, maxHealth);
		if (currentHealth <= minHealth) {
			Health.text = "Health: " + currentHealth;
			SceneManager.LoadScene (4);
			//The destroy call is only temporary. What would be best is to have sme sort of death animation, that once done, would bring up a game over screen.

		}
	}
	public void HealingDone(int heal){
		currentHealth += heal;
		currentHealth = Mathf.Clamp (currentHealth, minHealth, maxHealth);
	}
	public int getHealth (){
		return currentHealth;
	}
}
