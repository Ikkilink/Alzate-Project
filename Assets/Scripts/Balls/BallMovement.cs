using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public Vector2 force;
    
    void FixedUpdate()
    {
        Movement();
    }
 
    public void Movement()
    {
        rb.AddForce(force, ForceMode2D.Force);

    }
    private void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
    
}
