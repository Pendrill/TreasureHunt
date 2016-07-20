using UnityEngine;
using System.Collections;

public class MonsterSpawner : MonoBehaviour {
	public GameObject player;
	private int totalMonsters;
	void OnTriggerEnter2D(Collider2D player){
		totalMonsters = numberOfMonsters ();
		if (totalMonsters > 0) {
			//Instantiate the monster;
			//determine where they are based on player location
			totalMonsters-=1;
		}
	}
	public int numberOfMonsters(){
		if (player.GetComponent<StabilityManager> ().getStability () == 100) {
			return 0;
		}else if (player.GetComponent<StabilityManager> ().getStability () > 75) {
			return 1;
		}else if (player.GetComponent<StabilityManager> ().getStability () > 50) {
			return 3;
		}else if (player.GetComponent<StabilityManager> ().getStability () > 25) {
			return 5;
		}else {
			return 7;
		}

	}
}
