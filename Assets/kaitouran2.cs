using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaitouran2 : MonoBehaviour
{
    GameObject[] blue;
    GameObject[] green;
    GameObject[] yellow;
    public static int bcount2;
    public static int gcount2;
    public static int ycount2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("bluename"))
        {
            bcount2++;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount2++;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount2++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("bluename"))
        {
            bcount2--;
        }
        else if (collision.CompareTag("greenname"))
        {
            gcount2--;
        }
        else if (collision.CompareTag("yellowname"))
        {
            ycount2--;
        }
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
