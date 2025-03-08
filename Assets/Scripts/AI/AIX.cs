using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIX : MonoBehaviour
{
    public Rigidbody2D rbAI;
    public float RrTime;
    public float Randompos;
    private void Start()
    {
        StartCoroutine(SetRandomx());
    }
    private void FixedUpdate()
    {
        MoveAI();
    }
    public void MoveAI()
    {

        transform.position = new Vector2(Randompos, this.transform.position.y);

    }
    IEnumerator SetRandomx()
    {
        while (true)
        {
            Randompos = Random.RandomRange(-4.4f, 0);
            yield return new WaitForSeconds(RrTime);
        }

    }

}
