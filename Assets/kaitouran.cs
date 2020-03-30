using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class kaitouran : MonoBehaviour
{
     GameObject[] blue;
    GameObject[] green;
    GameObject[] yellow;
    public static int bcount;
    public static int gcount;
    public static int ycount;
     void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bluename"))
        {
            bcount++;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount++;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("bluename"))
        {
            bcount--;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount--;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount--;
        }
    }
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
}
