﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	// Update is called once per frame
	void update () {
		if (Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene ("Sample");
		}
	}
}
