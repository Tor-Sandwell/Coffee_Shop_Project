using UnityEngine;

public class ForLoop : MonoBehaviour
{
    [SerializeField] private string[] coffeeMenu = { "Espresso", "Latte", "Cappuccino", "Americano", "Mocha" };
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Coffee number: " + i);
        }
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Now serving: " + coffee);
        }
    }
}