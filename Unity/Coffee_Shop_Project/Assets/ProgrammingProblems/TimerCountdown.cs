using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimerCountdown : MonoBehaviour
{
    int timeRemaining = 10;
    
    void Start()//calls countdown function
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        Debug.Log(timeRemaining);
        while (timeRemaining > 0)//checks if timer has run out
        {
            yield return new WaitForSeconds(1);//waits for 1 second
            timeRemaining--;
            Debug.Log("Time remaining: " + timeRemaining);
        }
        Debug.Log("Timer finished!");
    }
}