using UnityEngine;

public class OrderOutput : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Tea");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Americano");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Latte");
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Debug.Log("Iced coffee");
        }
    }
}