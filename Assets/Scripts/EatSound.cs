using UnityEngine;
using System.Collections;

public class EatSound : MonoBehaviour {
	public AudioSource eat;

	public void takePill(){
		eat.PlayOneShot (eat.clip);
	}
}
