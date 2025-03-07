using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManagerEnemies : PoolManager
{
    float currentTime;
    float timeToSpawn = 5f;
    private void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > timeToSpawn)
        {
            AskForObject().transform.position = new Vector3(10, Random.Range(-4f, 4f));
        }
    }
}
