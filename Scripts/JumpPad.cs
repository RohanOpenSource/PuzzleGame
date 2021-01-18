using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.attachedRigidbody.velocity = new Vector2(collision.collider.attachedRigidbody.velocity.x, 20);                    
    }
}
