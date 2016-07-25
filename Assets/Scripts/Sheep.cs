using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Sheep : MonoBehaviour {
	public GameObject panelUI;
	public Text MessageUI;
	public string message;
	// Use this for initialization


	void OnTriggerEnter2D(Collider2D player){
		if (player.GetComponent<PlayerMovement> () != null) {
			panelUI.SetActive (true);
			MessageUI.text = message;
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (6);

			}


		}
	}

	void OnTriggerStay2D(Collider2D player){
		if (player.GetComponent<PlayerMovement> () != null) {
			panelUI.SetActive (true);
			MessageUI.text = message;
			if (Input.GetKeyDown (KeyCode.Space)) {
				SceneManager.LoadScene (6);

			}


		}
	}
	void OnTriggerExit2D(Collider2D player){
		if (player.GetComponent<PlayerMovement> () != null) {
			panelUI.SetActive (false);
			MessageUI.text = "";


		}
	}



}
