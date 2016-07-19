using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Treasure : MonoBehaviour {
	bool didPlayerWin = false;
	//The Stanzas
	public Text textString;
	//for guiding the player
	public Text textStringGuide;
	public Transform player;
	public Transform time;
	public Transform feels;
	public Transform choices;
	public Transform anxiety;
	public Transform pleasure;
	public Transform dating;
	int atStanza = 0;
	public float x;



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((player.position - transform.position).magnitude < 1100f) {
			atStanza = 7;
			textString.text = "Press [SPACE] to take your meds.";
			if (Input.GetKeyDown (KeyCode.Space))
				didPlayerWin = true;
			if (didPlayerWin) {
				textString.text = "I take my meds like they tell me to. I guess this is better.";
				textStringGuide.text = "Game over.";
			}
		} else if ((player.position - time.position).magnitude < 1100f) {
			textString.text = "I think about how time works a lot. We, supposedly, either have free will or we don’t. But what if only some of life had to happen?";
			atStanza = 1;
		} else if ((player.position - feels.position).magnitude < 1100f) {
			atStanza = 2;
			textString.text = "Everything feels so much lately. I take suggestions as demands, whispers become barks. I cover my ears, close my eyes, and breathe.";
		} else if ((player.position - choices.position).magnitude < 1100f) {
			textString.text = "Making decisions is really hard. There are too many options, too much unknown, too must be right. Even the little things are life or death.";
			atStanza = 3;
		} else if ((player.position - anxiety.position).magnitude < 1100f) {
			textString.text = "I hate being alone. It leaves me with just myself, and we're barely on speaking terms. I know it's the anxiety lying to me.";
			atStanza = 4;
		} else if ((player.position - pleasure.position).magnitude < 1900f) {
			textString.text = "Nothing is pleasureable anymore. Maybe it never was? Maybe I just don't understand pleasure works anymore.";
			atStanza = 5;
		} else if ((player.position - dating.position).magnitude < 1100f) {
			textString.text = "Dating is weird. I don't get it. I just want to cuddle and play games and eat. I don't want to be alone anymore.";
			atStanza = 6;
		} else if (atStanza == 1) {
			textStringGuide.text = "They tell me I ask big questions.\nThey tell me to take my meds. (Center)\nBut I don't want to. (Orange)";
		} else if (atStanza == 2) {
			textStringGuide.text = "They tell me I'm too sensitive.\nThey tell me to take my meds. (Center)\nBut I don't want to. (Yellow/Green)";
		} else if (atStanza == 3) {
			textStringGuide.text = "They tell me to hurry up.\nThey tell me to take my meds.(Center)\nBut I don't want to. (Teal/Blue)";
		} else if (atStanza == 4) {
			textStringGuide.text = "They tell me to get a hobby.\nThey tell me to take my meds. (Center)\nBut I don't want to. (Blue)";
		} else if (atStanza == 5) {
			textStringGuide.text = "They tell me to stop smoking.\nThey tell me to take my meds. (Center)\nBut I don't want to. (Pink)";
		} else if (atStanza == 6) {
			textStringGuide.text = "They tell me to journal.\nThey tell me to take my meds. (Center)\nBut I don't want to. (White)";
		} else if (atStanza == 7) {
			textStringGuide.text = "";
		} 
	
	}
}
