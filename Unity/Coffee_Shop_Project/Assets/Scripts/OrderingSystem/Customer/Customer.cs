using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    public readonly static string drinkType = "rooibos tea";
    public readonly static int drinkAmount = 1;
    public readonly static bool orderConfirmed = true;
    public UnityEvent raiseOrder;
    void Start()
    {
        RequestItem(drinkType, drinkAmount, orderConfirmed);
    }
    void RequestItem(string drinkType, int drinkAmount, bool orderConfirmed)
    {
        Debug.Log(drinkType + " " + drinkAmount + " " + orderConfirmed);
        raiseOrder?.Invoke();
    }
}