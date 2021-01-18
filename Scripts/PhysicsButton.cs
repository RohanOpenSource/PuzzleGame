using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsButton : MonoBehaviour
{
  public door attacheddoor;
  void OnCollisionStay2D(Collision2D c){
    Rigidbody2D rb=c.rigidbody;
    if(rb!=null){
      Debug.Log("pressed");
      attacheddoor.open();

    }

  }
  void OnCollisionExit2D(Collision2D c){
    Rigidbody2D rb=c.rigidbody;
    if(rb!=null){
      Debug.Log("pressed");
      attacheddoor.close();

    }

  }
}
