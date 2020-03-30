using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class decision2 : MonoBehaviour
{
    public static int score1;
    public Text score1text;

    public void decision()
    {
        SceneManager.LoadScene(2);
    }
    public void point()
    {
        if(kaitouran2.bcount2 == 2 && kaitouran2.gcount2 == 1 && kaitouran2.ycount2 == 0)
        {
            score1 = score1 + 3;
        }
        else if(kaitouran2.gcount2 == 2 && kaitouran2.ycount2 == 1 && kaitouran.bcount == 0)
        {
            score1 = score1 + 3;
        }
    }
    void Start()
    {
        score1 = decisionbutton.score;
    }

    void Update()
    {
        score1text.text = score1.ToString();
    }
}
