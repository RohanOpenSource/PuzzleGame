using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
  private Rigidbody2D rb;
  private float mx;
  public Transform feet;
  public LayerMask WhatIsGround;


  public bool isGrounded()
   {
     Collider2D groundCheck = Physics2D.OverlapCircle(feet.position, 0.2f, WhatIsGround);
     if(groundCheck != null) {
       return true;

     }
     return false;

   }

    void Start()
    {
      rb=GetComponent<Rigidbody2D>();

    }
    void Update()
    {
      mx=Input.GetAxisRaw("Horizontal");
      if(Input.GetButtonDown("Jump")&& isGrounded()){
        Jump();
      }
      if(Input.GetKey("d")||Input.GetKey(KeyCode.RightArrow)){
        transform.eulerAngles=new Vector3(0,0,-10);
      }
      else if(Input.GetKey("a")||Input.GetKey(KeyCode.LeftArrow)){
        transform.eulerAngles=new Vector3(0,0,10);
      }
      else{
        transform.eulerAngles=new Vector3(0,0,0);
      }
      if(!isGrounded()){
        transform.localScale=new Vector3(0.6f,1.2f,1f);
      }
      else{
        transform.localScale=new Vector3(0.5f,1.5f,1f);
      }


    }
    void FixedUpdate(){
      rb.velocity=new Vector2(3.5f*mx,rb.velocity.y);

    }
    void Jump(){
      rb.velocity=new Vector2(rb.velocity.x,12);

    }
}
