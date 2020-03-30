﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer3 : MonoBehaviour
{
    private float totalTime;
    [SerializeField]
    private int minute;
    [SerializeField]
    private float seconds;
    private float oldSeconds;
    private Text timerText;
    void Start()
    {
        totalTime = minute * 30 + seconds;
        oldSeconds = 0f;
        timerText = GetComponentInChildren<Text>();
    }


    void Update()
    {
        if (totalTime <= 0f)
        {
            return;
        }
        totalTime = minute * 30 + seconds;
        totalTime -= Time.deltaTime;
        minute = (int)totalTime / 60;
        seconds = totalTime - minute * 60;

        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");

        }
        oldSeconds = seconds;
        if (totalTime <= 0f)
        {
            SceneManager.LoadScene(3);
        }
    }
}
