using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
  public SpriteRenderer r;
  public void open(){
    r.enabled=false;
    gameObject.GetComponent<BoxCollider2D>().enabled=false;

  }
  public void close(){
    r.enabled=true;
    gameObject.GetComponent<BoxCollider2D>().enabled=true;
  }
}
