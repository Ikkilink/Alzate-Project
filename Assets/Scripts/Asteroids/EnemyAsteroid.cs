using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAsteroid : MonoBehaviour
{
    float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left*Time.deltaTime*speed);
    }
}
