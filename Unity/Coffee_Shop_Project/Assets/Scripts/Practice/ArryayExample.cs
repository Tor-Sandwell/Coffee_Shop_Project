using UnityEngine;
using System.Collections.Generic;

public class ArryayExample : MonoBehaviour
{
    public GameObject[] gameObject;
    public List<GameObject> gameObjectList = new List<GameObject>();

    public void Start()
    {
        foreach (GameObject obj in gameObjectList)
        {
            Debug.Log("Game object in list: " + obj.name);
        }
    }
    public void Update()
    {

    }
}