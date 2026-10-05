using UnityEngine;
using System.Collections.Generic;

public class ArrayTest : MonoBehaviour
{
    public float[]values;
    void Start()
    {
        foreach (float value in values)
        {
            Debug.Log(value);
        }
        values = new float[10];
        values[1] = 5.0f;
    }
}
