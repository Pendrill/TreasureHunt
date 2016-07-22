using UnityEngine;
using System.Collections;

public class MonsterSpawner : MonoBehaviour {
	public GameObject player;
	public GameObject monsters;
	public Vector3 roomCenter;
	private int totalMonsters;
	private Vector3 roomCenterOG;

	void Start(){
		roomCenterOG = roomCenter;
	}

	void Update(){
		roomCenter = roomCenterOG;
	}

	void OnTriggerEnter2D(Collider2D player){
		totalMonsters = numberOfMonsters ();
		while (totalMonsters > 0) {
			//Instantiate the monster;
			//determine where they are based on player location
			//roomCenter += new Vector3 (Random.Range(-350,350),Random.Range(-350,350),0);
			Instantiate (monsters, roomCenter+ new Vector3 (Random.Range(-350,350),Random.Range(-350,350),0), Quaternion.identity);
			totalMonsters-=1;
		}
	}
	void OnTriggerExit2D(Collider2D player){
		Destroy (this);
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
