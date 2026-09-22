using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TimerCountdown : MonoBehaviour
{
    
    void Start()//calls countdown function
    {
        if (targetObject == null)
        {
            targetPlayer = GameObject.Find("player");
            targetObject = GameObject.Find("object");
        }
        if (targetObject != null)
        {
            vector3 playerPosition = targetPlayer.transform.position;
            vector3 objectPosition = targetObject.transform.position;
        }
        else
        {
            Debug.Log("Target object not found.");
        }
        if (targetObject == null)
        {
            targetPlayer = GameObject.Find("player");
            targetObject = GameObject.Find("object");
        }
            StartCoroutine(Interval());

        {
            vector3 playerPosition = targetPlayer.transform.position;
            vector3 objectPosition = targetObject.transform.position;
        }

        {
            Debug.Log("Target object not found.");
        }
            StartCoroutine(Interval());

    IEnumerator Interval()
    {
        Debug.Log(timeRemaining);
            yield return new WaitForSeconds(2);//waits for 2 seconds
            vector3.Distance = Vector3.Distance(playerPosition, objectPosition);
            Debug.Log("Distance: " + vector3.Distance);
    }
}