using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaitouran3 : MonoBehaviour
{
    GameObject[] blue;
    GameObject[] green;
    GameObject[] yellow;
    public static int bcount3;
    public static int gcount3;
    public static int ycount3;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bluename"))
        {
            bcount3++;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount3++;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount3++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("bluename"))
        {
            bcount3--;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount3--;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount3--;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
