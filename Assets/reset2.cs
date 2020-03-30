using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class reset2 : MonoBehaviour
{
    public void reset()
    {
        SceneManager.LoadScene(1);
    }
    public void bluereset()
    {
        if (kaitouran2.bcount2 >= 0)
        {
            kaitouran2.bcount2 = 0;
        }
    }
    public void greenreset() {
        if (kaitouran2.gcount2 >= 0)
        {
            kaitouran2.gcount2 = 0;
        }
    }
    public void yellowreset()
    {
        if (kaitouran2.ycount2 >= 0)
        {
            kaitouran2.ycount2 = 0;
        }
    }
}
