using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset3 : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene(2);
    }
    public void bluereset()
    {
        if (kaitouran3.bcount3 >= 0)
        {
            kaitouran3.bcount3 = 0;
        }
    }
    public void greenreset()
    {
        if (kaitouran3.gcount3 >= 0)
        {
            kaitouran3.gcount3 = 0;
        }
    }
    public void yellowreset()
    { 
         if (kaitouran3.ycount3 >= 0)
        {
            kaitouran3.ycount3 = 0;
        }
    }
}
