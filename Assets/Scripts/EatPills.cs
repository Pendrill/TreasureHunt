using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EatPills : MonoBehaviour {
	public GameObject ignoreThePills;
	public GameObject panelUI;
	public Text textUI;
	public string message;
	public bool needTeleport=false;
	public Vector3 playerNewPosition;
	public bool changePath = false;
	public GameObject pathOne;
	public GameObject pathTwo;
	public bool lastPill = false;
	public GameObject Sheep;

	//The amount of stability the player can regain will be determined by their current health.
	void OnTriggerEnter2D(Collider2D player){
		if (player.GetComponent<MoveBullet> () != null) {
			Destroy (player.gameObject);

		} else {
			panelUI.SetActive (true);
			textUI.text = message;
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
	}
	void OnTriggerStay2D(Collider2D player){
		if (lastPill) {
			Debug.Log ("Hello");
			Sheep.SetActive (true);
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("You are pressing SPACE");
			//Destroy (ignoreThePills.gameObject);
			if (needTeleport) {
				player.gameObject.transform.position = playerNewPosition;
			}

			if (changePath) {
				pathOne.SetActive (true);
				pathTwo.SetActive (false);
			}
			if (lastPill) {
				SceneManager.LoadScene (5);
			}
			if (player.GetComponent<HealthManager> ().getHealth () >= 70) {
				player.GetComponent<StabilityManager> ().gainStability (30);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 50) {
				player.GetComponent<StabilityManager> ().gainStability (15);
			} else if (player.GetComponent<HealthManager> ().getHealth () >= 25) {
				player.GetComponent<StabilityManager> ().gainStability (5);
			} else {
				player.GetComponent<StabilityManager> ().gainStability (1);
			}
			player.GetComponent<EatSound> ().takePill ();
			Destroy (this.gameObject);
			Destroy (ignoreThePills.gameObject);
			panelUI.SetActive (false);
			textUI.text = "";
		}
	}
	void OnTriggerExit2D(Collider2D player){
		panelUI.SetActive (false);
		textUI.text = "";
	}
}
