using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour
{
    public float forceJump;
    public Rigidbody2D rb2d;
    public bool canJump = false;

    public ScoreObject refScoreObject;

    public delegate void CollisionWithPlatform();
    public CollisionWithPlatform onCollisionWithPlaform;

    public delegate void OnTrigger();
    public OnTrigger onTriggerEnter;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        onCollisionWithPlaform?.Invoke();

        canJump = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        canJump = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entro en trigger");
        onTriggerEnter?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * forceJump, ForceMode2D.Impulse);
        }
    }
}

// abstract void FuncionAbstracta();

// virtual void FuncionVirtual()
//{
//}