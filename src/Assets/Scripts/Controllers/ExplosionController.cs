using UnityEngine;
using System.Collections;

public class ExplosionController : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		anim.StopPlayback ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
