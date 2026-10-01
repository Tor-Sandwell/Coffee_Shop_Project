using UnityEngine;

public class CoffeeMachine : MonoBehaviour
{

    private bool coffeeMachineOn = true;

    void Start()
    {
        if (coffeeMachineOn)
        {
            Debug.Log("Coffee Machine is on");
        }
        else
        {
            Debug.Log("Coffee Machine is off");
        }
    }
}
