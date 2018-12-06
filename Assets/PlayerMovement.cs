using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public CharacterController2D controller;
    public float runspeed = 400f;
    public Animator animator;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        horizontalMove =Input.GetAxisRaw("Horizontal")* runspeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (Input.GetButtonDown("Jump")) {
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch")) {
            crouch = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;
    }
    public void onLanding()
    {
        animator.SetBool("isJumping", false);
    }
 /*   public void onCrounching(bool isCrounching)
    {
        animator.SetBool("isCrouching", isCrounching);
    }
    */
}
