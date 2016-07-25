using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EatPills : MonoBehaviour {
	public GameObject panelUI;
	public Text textUI;
	public string message;

	//The amount of stability the player can regain will be determined by their current health.
	void OnTriggerEnter2D(Collider2D player){
		panelUI.SetActive (true);
		textUI.text = message;
		/*(if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("working?");
			if (player.GetComponent<HealthManager> ().getHealth () >= 70) {
				player.GetComponent<StabilityManager> ().gainStability (30);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 50) {
				player.GetComponent<StabilityManager> ().gainStability (15);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 25) {
				player.GetComponent<StabilityManager> ().gainStability (5);
			} else {
				player.GetComponent<StabilityManager> ().gainStability (1);
			}
			Destroy (this.gameObject);
		}*/


	}
	void OnTriggerStay2D(Collider2D player){
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("working?");
			if (player.GetComponent<HealthManager> ().getHealth () >= 70) {
				player.GetComponent<StabilityManager> ().gainStability (30);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 50) {
				player.GetComponent<StabilityManager> ().gainStability (15);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 25) {
				player.GetComponent<StabilityManager> ().gainStability (5);
			} else {
				player.GetComponent<StabilityManager> ().gainStability (1);
			}
			Destroy (this.gameObject);
		}
	}
	void OnTriggerExit2D(Collider2D player){
		panelUI.SetActive (false);
		textUI.text = "";
	}
}
