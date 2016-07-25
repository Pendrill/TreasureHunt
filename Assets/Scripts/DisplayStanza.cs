using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DisplayStanza : MonoBehaviour {
	public GameObject PanelUI;
	public Text textUI;
	public string Stanza;
	// Use this for initialization

	void OnTriggerEnter2D(Collider2D Player){
		if (Player.GetComponent<PlayerMovement> () != null) {
			PanelUI.SetActive (true);
			textUI.text = Stanza;
		}

	}
	void OnTriggerStay2D(Collider2D Player){
		if (Player.GetComponent<PlayerMovement> () != null) {
			PanelUI.SetActive (true);
			textUI.text = Stanza;
		}

	}
	void OnTriggerExit2D(Collider2D Player){
		if (Player.GetComponent<PlayerMovement> () != null) {
			PanelUI.SetActive (false);
			textUI.text = "";
		}
	}

}
