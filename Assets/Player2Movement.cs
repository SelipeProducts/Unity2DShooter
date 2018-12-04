using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Movement : MonoBehaviour
{

    public CharacterController2D controller;
    public float runspeed = 120f;
    public Animator animator;
    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
/*    void Update(){
        horizontalMove = Input.GetAxisRaw("HorizontalP2") * runspeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        if (Input.GetKeyDown("Player2J"))
        {
            Debug.Log(Input.GetKeyDown("Player2J"));
            jump = true;
          //  animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("CrouchP2"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("CrouchP2"))
        {
            crouch = false;
        }
    }
    */

    void Update()
    {
        
        //not working??????????
   
         if (Input.GetKeyDown("p")){
           // Debug.Log("INPUT DEBUG: p");
            jump = true;
            animator.SetBool("isJumping", true);
        }
        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
        //had to move to bottom on top jump was not regerstering if statement????????????????????
        horizontalMove = Input.GetAxisRaw("HorizontalP2") * runspeed;
        animator.SetFloat("speed", Mathf.Abs(horizontalMove));
        //
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;

    }
 /*   public void onLanding()
    {
        //animator.SetBool("isJumping", false);
    }
    public void onCrounching(bool isCrounching)
    {
        //animator.SetBool("isCrouching", isCrounching);
    }
 */

}
