using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimeTracker;
    public bool isTimer = false;
    public bool isAnimating = false;

    public TMP_Text TimerTxt;

    public Animator CubeAnimator;

    /*
    void Start()
    {
        isTimer = true;
    }
    */

    public void startTimer() 
    {
        isTimer = true;
    }

    void Update()
    {
        if (isTimer) 
        {
            if (TimeTracker >= 0)
            {
                TimeTracker += Time.deltaTime;
                updateTimer(TimeTracker);
            }
            else 
            {
                Debug.Log("Time is up");
                TimeTracker = 0;
                isTimer = false;

                if (!isAnimating)
                {
                    CubeAnimator.Play("LoopCube");
                    isAnimating = true;
                }
            }
        }
    }

    void updateTimer (float currentTime) 
    {
        currentTime += 1;

        float min = Mathf.FloorToInt(currentTime / 60);
        float sec = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", min, sec);
    }
}
