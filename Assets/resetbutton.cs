using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetbutton : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene(0);
    }
    public void bluereset()
    {
        if(kaitouran.bcount >= 0)
        {
            kaitouran.bcount = 0;
        }
    }
    public void greenreset()
    {
        if(kaitouran.gcount >= 0)
        {
            kaitouran.gcount = 0;
        }
    }
    public void yellowreset()
    {
        if(kaitouran.ycount >= 0)
        {
            kaitouran.ycount = 0;
        }
    }
}
