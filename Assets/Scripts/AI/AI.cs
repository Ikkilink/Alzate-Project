using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    public Rigidbody2D rbAI;
    public float RrTime;
    public float Randompos;
    private void Start()
    {
        StartCoroutine(SetRandom());
    }
    private void FixedUpdate()
    {
        MoveAI();
    }
    public void MoveAI()
    {
        
        transform.position = new Vector2(this.transform.position.x, Randompos);
        
    }
    IEnumerator SetRandom()
    {
        while (true)
        {
            Randompos = Random.RandomRange(-2.6f, 2);
            yield return new WaitForSeconds(RrTime);
        }

    }

}
