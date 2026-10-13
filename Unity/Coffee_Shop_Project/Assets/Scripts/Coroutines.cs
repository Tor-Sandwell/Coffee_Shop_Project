using UnityEngine;
using System.Collections;

public class Coroutines : MonoBehaviour
{
    public float testCoroutineTimer = 2f;
    private void Start()
    {
        StartCoroutine(TestCoroutine());
    }
    private IEnumerator TestCoroutine()
    {
        yield return new WaitForSeconds(testCoroutineTimer);
        Debug.Log("TestCoroutine");
    }
}