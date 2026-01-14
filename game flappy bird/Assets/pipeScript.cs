using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    float nilaiRandom; // nilai desimal
    // Start is called before the first frame update
    void Start()
    {
        nilaiRandom = Random.Range(-3.9f, 0.11f);
        transform.position = new Vector2(transform.position.x, nilaiRandom);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Vector2.left * 100, Time.deltaTime * 5);
    }
}
