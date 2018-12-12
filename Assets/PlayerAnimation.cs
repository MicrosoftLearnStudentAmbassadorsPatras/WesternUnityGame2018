using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>();		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            anim.SetBool("isWalking", true);
        else
            anim.SetBool("isWalking", false);
        if (Input.GetKey(KeyCode.W))
            anim.SetBool("isJumping", true);
        else
            anim.SetBool("isJumping", false);
        if (Input.GetKey(KeyCode.Space))
            anim.SetTrigger("fire");
    }
}
