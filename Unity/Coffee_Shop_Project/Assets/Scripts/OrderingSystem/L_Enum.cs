using UnityEngine;

public class L_Enum : MonoBehaviour
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano
    }

    [SerializeField]
    private CoffeeType _coffeeType = CoffeeType.Espresso;

    void Start()
    {
        switch (_coffeeType)
        {
            case CoffeeType.Espresso:
                Debug.Log("You selected Espresso.");
                break;
            case CoffeeType.Latte:
                Debug.Log("You selected Latte.");
                break;
            case CoffeeType.Cappuccino:
                Debug.Log("You selected Cappuccino.");
                break;
            case CoffeeType.Americano:
                Debug.Log("You selected Americano.");
                break;
        }
    }
}
