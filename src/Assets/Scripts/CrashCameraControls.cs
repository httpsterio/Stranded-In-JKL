using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CrashCameraControls : MonoBehaviour {
	// ping-pong animate background color
	Color color2 = Color.black;
	Color color1 = new Color(0.7f, 1, 1, 1);
	float duration = 15.0f;
	float changeTimer = 0;
	// Set clear flags to color
	//camera.clearFlags = CameraClearFlags.SolidColor;
	
	void FixedUpdate () {

		Vector3 spaceShipPosition = GameObject.Find ("Spaceship").transform.position;
		Vector3 newPos = transform.position;
		newPos.y = spaceShipPosition.y+5;
		transform.position = newPos;

        camera.backgroundColor = Color.black;

		if (Dialoguer.GetGlobalBoolean (3)) {
			float t = Mathf.Pow (Time.time, duration) / duration;
            camera.backgroundColor = Color.black;

			changeTimer += Time.fixedDeltaTime;
			if (changeTimer > 8) {

                Dialoguer.SetGlobalBoolean(3, false);

				Application.LoadLevel ("StartScene");
			}
		}

	}

}
