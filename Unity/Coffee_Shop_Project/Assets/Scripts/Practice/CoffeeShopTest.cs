    using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int CoffeesSold;
    public float CoffeePrice = 3.50f;
    public int CoffeesOrdered = 3;
    void Start()
    {
        Debug.Log("Hello World");

        Debug.Log("I have ordered "+ CoffeesOrdered + " Coffees");
        AddCoffee(CoffeesOrdered);
        Debug.Log("Coffees sold: " + CoffeesSold);
    }

    void AddCoffee(int coffeesOrdered)
    {
        CoffeesSold += coffeesOrdered;
    }

}
