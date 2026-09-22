using UnityEngine;

public class Ordering_System : MonoBehaviour
{
    //Initializing variables.
    public int coffeeAmount;
    public float costOfCoffee = 3.99f;
    public float totalOrderCost;

    //Fibonacci Sequence variables.
    // public int x = 1;
    // public int y;
    // public int z;
    // public int i = 1;

    //Fibonacci Sequence Calculation.
    // void Start()
    // {
    //     while (i <=45)
    //     {
    //         z = x + y;
    //         Debug.Log(z);
    //         y = x;
    //         x = z;
    //         i++;
    //         if (z < 0)
    //         {
    //             Debug.Log(i);
    //             i = 101;
    //         }
    //     }
    // }

    //Calculate total order cost.
    public void AmountPlaced(int coffeeAmount)
    {
        //Calculate cost.
        totalOrderCost = coffeeAmount * costOfCoffee;
        //output cost.
        Debug.Log("Total Order Cost: £" + totalOrderCost);
    }
}
