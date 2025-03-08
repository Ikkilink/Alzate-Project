using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalReturn : MonoBehaviour
{
    public int BallLayer;
    public int players;
    GameManager manager;
    private void Start()
    {
        manager = GameManager.Instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == BallLayer)
        {
            manager.Takelife(players);
        }
    }
}
