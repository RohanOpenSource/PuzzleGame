using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsButton1 : MonoBehaviour
{
  public door attacheddoor;

    private void Start()
    {
        attacheddoor.open();
    }
    void OnCollisionStay2D(Collision2D c){
    Rigidbody2D rb=c.rigidbody;
    if(rb!=null){
      Debug.Log("pressed");
      attacheddoor.close();

    }

  }
  void OnCollisionExit2D(Collision2D c){
    Rigidbody2D rb=c.rigidbody;
    if(rb!=null){
      Debug.Log("pressed");
      attacheddoor.open();

    }

  }
}
