using System.Security.Cryptography;
using UnityEngine;

public class JumpScare : MonoBehaviour
{
    void Update()
    {
        int jumpScare = UnityEngine.Random.Range(0, 72000);
        if (jumpScare == 0)
        {
            switch (UnityEngine.Random.Range(0,10))
            {
                case 0:
                Debug.Log(0);
                break;
                case 1:
                Debug.Log(1);
                break;
                case 2:
                Debug.Log(2);
                break;
                case 3:
                Debug.Log(3);
                break;
                case 4:
                Debug.Log(4);
                break;
                case 5:
                Debug.Log(5);
                break;
                case 6:
                Debug.Log(6);
                break;
                case 7:
                Debug.Log(7);
                break;
                case 8:
                Debug.Log(8);
                break;
                case 9:
                Debug.Log(9);
                break;
            }
        }
        if (Input.GetKeyDown(KeyCode.A) & Input.GetKeyDown(KeyCode.C))
        {
            
        }
    }
}