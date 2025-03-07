using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour
{
    public int startingObjectsCount = 5;
    public GameObject prefabToCreate;
    public List<GameObject> createdObjects;

    // Start is called before the first frame update
    void Start()
    {
        FillObjectList();
        StartFunction();
    }

    public void FillObjectList()
    {
        for (int indexCreated = 0; indexCreated < startingObjectsCount; indexCreated++)
        {
            GameObject createdObject = Instantiate(prefabToCreate);
            createdObject.SetActive(false);
            createdObjects.Add(createdObject);
        }
    }

    public virtual void StartFunction()
    {

    }

    public GameObject AskForObject()
    {
        GameObject returnedObject = null;

        for (int indexCreatedObjects = 0; indexCreatedObjects < createdObjects.Count; indexCreatedObjects++)
        {
            if (!createdObjects[indexCreatedObjects].activeInHierarchy)
            {
                returnedObject = createdObjects[indexCreatedObjects];
                returnedObject.SetActive(true);
                break;
            }
        }

        return returnedObject;
    }
}
