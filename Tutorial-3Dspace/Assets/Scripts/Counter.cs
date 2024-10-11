using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Counter : MonoBehaviour
{
    public TMP_Text ScoreCounter;

    public int CounterNum;

    void Update()
    {
        UpdateScore();
    }

    void UpdateScore() 
    {
        ScoreCounter.text = string.Format("{0}", CounterNum);
    }

    public void ButtonScoreIncrease() 
    {
        CounterNum++;
    }

    public void ButtonScoreDecrease() 
    {
        CounterNum--;
    }
}
