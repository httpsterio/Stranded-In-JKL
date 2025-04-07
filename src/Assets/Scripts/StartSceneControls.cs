using UnityEngine;
using System.Collections;

public class StartSceneControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void startGame() {
		Application.LoadLevel("IntroScene");
	}

	public void quitGame() {
		Application.Quit ();
	}

}
