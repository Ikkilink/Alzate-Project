using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public float timeToSpawn = 2f;
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
