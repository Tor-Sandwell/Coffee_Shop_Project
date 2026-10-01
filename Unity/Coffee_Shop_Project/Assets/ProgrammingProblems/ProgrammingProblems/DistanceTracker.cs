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
        if (targetObject == null)//finds the object in scene
        {
            targetObject = GameObject.Find("object");
        }
        if (targetPlayer == null)
        {
            targetPlayer = GameObject.Find("player");
        }
        
            Vector3 playerPosition = targetPlayer.transform.position;
            Vector3 objectPosition = targetObject.transform.position;
        
            StartCoroutine(Interval(playerPosition, objectPosition));
        
        
       
      IEnumerator Interval(Vector3 playerPosition, Vector3 objectPosition)
        {
            while (true)
            {
                yield return new WaitForSeconds(2);//waits for 2 seconds
                float distance = Vector3.Distance(playerPosition, objectPosition);
                Debug.Log("Distance: " + distance);
            }
        }
    }
}