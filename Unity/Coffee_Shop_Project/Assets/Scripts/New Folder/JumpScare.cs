using UnityEngine;

public class JumpScare : MonoBehaviour
{
    void Update()
    {
        int jumpScare = UnityEngine.Random.Range(1, 72001);
        if (jumpScare == 1)
        {
            Debug.Log("Jump Scare!");
        }
    }
}