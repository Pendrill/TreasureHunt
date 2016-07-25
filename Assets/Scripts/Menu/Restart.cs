﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.R)) {
			int CurrentSceneNumber = SceneManager.GetActiveScene ().buildIndex;
			SceneManager.LoadScene (CurrentSceneNumber);
		}
	}
}
