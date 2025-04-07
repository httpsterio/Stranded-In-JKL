using UnityEngine;
using System.Collections;

public class SpaceshipCrashControls : MonoBehaviour {

	Transform target, spaceShip;
	GameObject explosion;

	float speed = 4.5f;
	bool showDialog = false;
	//bool showExplosion = false;
	float explosionTimer = -1f;


	// Use this for initialization
	void Start () 
    {
		explosion = GameObject.Find ("ExplosionSpriteSheet");
        target = GameObject.Find("Watertower").transform;
        spaceShip = GameObject.Find("Spaceship").transform;
		explosion.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () 
    {	
		if (transform.position.x > 9 && !showDialog) 
        {
			//GameObject explosion2 = GameObject.Find ("ExplosionSpriteSheet");
			showDialog = true;
			explosionTimer = 0.3f;
			GameManager.instance.Conversation(1);
		}

		explosionTimer -= Time.deltaTime;
		if (explosionTimer >= 0)
			explosion.SetActive (true);
		else
			explosion.SetActive(false);

	}

    void FixedUpdate()
    {
        // Move our position a step closer to the target.
        spaceShip.transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

}
