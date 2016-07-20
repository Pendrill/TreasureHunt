using UnityEngine;
using System.Collections;

public class HealthManager : MonoBehaviour {

	public int currentHealth;
	public int maxHealth;
	public int minHealth;
	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void DamageDone(int damage){
		currentHealth -= damage;
		currentHealth = Mathf.Clamp (currentHealth, minHealth, maxHealth);
		if (currentHealth <= minHealth) {
			Destroy (gameObject);
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
