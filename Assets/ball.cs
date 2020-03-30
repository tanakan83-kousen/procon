using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject[] drop;
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            int number = Random.Range(0, drop.Length);
            Instantiate(drop[number], transform.position, transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
