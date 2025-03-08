using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListManager : MonoBehaviour
{
    public int startObjectCount = 7; //Numero limite de objetos que se van a crear
    public GameObject ballPrefab;//Prefab que spawneara
    public List<GameObject> createdObjects;//lista dinamica de objetos que se van a agregar (balls)
    void Start()
    {
        FillObjectsList();
        StartFuntion();
    }
    public void FillObjectsList()
    {
        for (int index = 0; index < startObjectCount; index++)// index = 0 (numero en el que va a empezar la cuenta del for each); index<x (cuando va a dejar de realizar el for); index++ agregar objetos
        {
            GameObject createdObject = Instantiate(ballPrefab);
            createdObject.SetActive(false);
            createdObjects.Add(createdObject);
        }
    }
    public virtual void StartFuntion()
    {

    }
    public GameObject AskForObject()
    {
        GameObject returnedObject = null;
        for (int indexObjectsCreated = 0; indexObjectsCreated < createdObjects.Count; indexObjectsCreated++)
        {
            if (!createdObjects[indexObjectsCreated].activeInHierarchy)
            {
                returnedObject = createdObjects[indexObjectsCreated];
                returnedObject.SetActive(true);
                break;
            }
        }
        return returnedObject;
    }
}
