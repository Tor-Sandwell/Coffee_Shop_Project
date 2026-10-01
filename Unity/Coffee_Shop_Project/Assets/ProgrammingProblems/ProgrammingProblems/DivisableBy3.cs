using UnityEngine;

public class DivisableBy3 : MonoBehaviour
{
    //Variable initialization
    [SerializeField] private int number;
    [SerializeField] private int divisor = 3;

    //call modulo function
    private void Start()
    {
        Modulo(number, divisor);
    }

    //check if divisable by divisor
    private void Modulo(int number, int divisor)
    {
        if (divisor == 0)//check if divisor is 0
        {
            Debug.LogError("Divisor cannot be zero.");
            return;
        }
        else if (number % divisor == 0)//check if divisable by divisor
        {
            Debug.Log(number + " is divisible by " + divisor);
        }
        else
        {
            Debug.Log(number + " is not divisible by " + divisor);
        }
    }
}