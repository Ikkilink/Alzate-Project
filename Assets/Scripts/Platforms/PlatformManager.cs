using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformManager : PoolManager
{
    public float timeToSpawn = 3f;
    public Transform pointToSet;
    public override void StartFunction()
    {
        StartCoroutine(RoutineSetPlatform());
    }

    IEnumerator RoutineSetPlatform()
    {
        while (true)
        {
            AskForObject().transform.position = pointToSet.position;
            yield return new WaitForSeconds(timeToSpawn);
        }
        
    }
}
