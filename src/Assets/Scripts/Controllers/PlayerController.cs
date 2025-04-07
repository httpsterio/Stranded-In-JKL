using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public static PlayerController instance { get; private set; }

	protected Animator animator;

	public Vector3 playerPosition { get; private set; } 
	public float distance { get; private set; }

	public float speed = 0.8f;
	public float stopDistance = 0.7f;

    private Vector3 movePosition;
	private bool move = false;
    private bool audioPlaying = false;

    AudioSource walkSound;

	// Use this for initialization
	void Start () {
		instance = this;
		distance = 0f;

		playerPosition = GameObject.Find("Alien_final").transform.position;
		movePosition = playerPosition;

        walkSound = GameObject.Find("Alien_final").GetComponent<AudioSource>();
        walkSound.loop = true;
        walkSound.Stop();

		animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (playerPosition, movePosition);
		playerPosition = GameObject.Find("Alien_final").transform.position;

		if(distance < stopDistance)
			move = false;


		if(move)
        {
            animator.SetFloat("Speed", speed);

            if(!audioPlaying)
            {
                walkSound.Play();
                audioPlaying = true;
            }
            
            
        }        
        else
        {
            animator.SetFloat("Speed", 0f);

            if (audioPlaying)
            {
                walkSound.Stop();
                audioPlaying = false;
            }
        }
                  		
	}

	public void setMovePosition(Vector3 newPos) {
		newPos.y = 0.1f;
		movePosition = newPos;

		transform.LookAt(movePosition);

		move = true;
	}

}
