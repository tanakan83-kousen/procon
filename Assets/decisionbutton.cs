using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class decisionbutton : MonoBehaviour
{
    public static int score;
    public Text scoretext;
    public  void decision()
    {
        SceneManager.LoadScene(1);
    }
    private void Start()
    {
        
    }
    public void point()
    {
      if(kaitouran.bcount == 2 && kaitouran.gcount ==1 && kaitouran.ycount == 0)
        {
            score = score + 3;
        }
      else if(kaitouran.gcount == 2 && kaitouran.ycount == 1 && kaitouran.bcount == 0)
        {
            score = score + 3;
        }
    }
    
   
    private void Update()
    {
        scoretext.text = score.ToString();
    }
}