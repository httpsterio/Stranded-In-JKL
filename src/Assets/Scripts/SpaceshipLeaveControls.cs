using UnityEngine;
using System.Collections;

public class SpaceshipLeaveControls : MonoBehaviour {

	Transform target, spaceShip;
	float speed = 40;
	bool conversationOpen = false;
    

	void Awake() {
		//GameManager.instance.Conversation (19);
	}

	// Use this for initialization
	void Start () 
    {
		target = GameObject.Find("Goal").transform;
        spaceShip = GameObject.Find("Spaceship").transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {

		if (!conversationOpen) {
			conversationOpen = true;
			GameManager.instance.Conversation (19);
		}

		if (Dialoguer.GetGlobalBoolean(3)) {
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            spaceShip.transform.Rotate(Vector3.up, Time.deltaTime * speed, Space.World);
		}     
	}
}
