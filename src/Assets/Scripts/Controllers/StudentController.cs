using UnityEngine;
using System.Collections;

public class StudentController : MonoBehaviour {

    protected Animator animator;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        
	}

    void Update()
    {
        animator.SetFloat("Speed", 0f);
    }
}
