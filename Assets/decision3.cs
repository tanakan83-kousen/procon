using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class decision3 : MonoBehaviour
{
    public static int score2;
    public Text score2text;
    public void decision()
    {
        SceneManager.LoadScene(3);
    }
    public void point()
    {
        if(kaitouran3.bcount3 == 2 && kaitouran3.gcount3 == 1 && kaitouran3.ycount3 == 0)
        {
            score2 = score2 + 3;
        }
        else if(kaitouran3.gcount3 == 2 && kaitouran3.ycount3 == 1 && kaitouran3.bcount3 == 0)
        {
            score2 = score2 + 3;
        }
    }
    void Start()
    {
        score2 = decision2.score1;
    }

    // Update is called once per frame
    void Update()
    {
        score2text.text = score2.ToString();
    }
}
