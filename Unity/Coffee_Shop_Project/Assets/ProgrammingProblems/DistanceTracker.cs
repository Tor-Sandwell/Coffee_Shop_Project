using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using  Vector3 = UnityEngine.Vector3;

public class DistanceTracker : MonoBehaviour
{
    private GameObject targetPlayer;
    private GameObject targetObject;    
    
    void Start()//calls countdown function
    {
        if (targetObject == null)
        {
            targetObject = GameObject.Find("object");
        }
        if (targetObject != null)
        {
            Vector3 objectPosition = targetObject.transform.position;
        }
        else
        {
            Debug.Log("Target object not found.");
        }
        if (targetPlayer == null)
        {
            targetPlayer = GameObject.Find("player");
        }
        else
        {
            Debug.Log("Target player not found.");
        }
        {
            Vector3 playerPosition = targetPlayer.transform.position;
            Vector3 objectPosition = targetObject.transform.position;
        }
            StartCoroutine(Interval(playerPosition, objectPosition));

        IEnumerator Interval(Vector3 playerPosition, Vector3 objectPosition)
        {
            yield return new WaitForSeconds(2);//waits for 2 seconds
            float distance = Vector3.Distance(playerPosition, objectPosition);
            Debug.Log(distance);
        }
    }
}