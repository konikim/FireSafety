using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour {

	public Camera c;
	// Update is called once per frame
	void Update () {
		if(Button.click)
			c.transform.Rotate (0, 90, 0);
	}
}
