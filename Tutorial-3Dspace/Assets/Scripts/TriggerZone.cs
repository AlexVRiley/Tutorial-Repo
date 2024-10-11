using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public GameObject counter;
    public Counter CounterScript;

    private void Start()
    {
        CounterScript = counter.GetComponent<Counter>();
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            CounterScript.ButtonScoreIncrease();
        }
    }
}
