using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour{

	public static bool click = false; 
	public Camera c;
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			c.transform.Rotate (0, 90, 0);
		}

	}
}