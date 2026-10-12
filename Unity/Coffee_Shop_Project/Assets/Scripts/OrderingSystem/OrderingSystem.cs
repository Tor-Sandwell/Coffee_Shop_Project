using System.Runtime.CompilerServices;
using UnityEngine;

public class OrderingSystem : MonoBehaviour
{
    public enum OrderItem
    {
        Coffee,
        Tea,
        soft_drink,
        cake_slice,
        biscuit,
    }

    public void Order(OrderStruct OrderItem, bool isOrderComplete)
    {
        if (isOrderComplete)
        {
            OrderCompletion.CompleteOrder();
        }
        AddItemToOrder.AddItem(OrderItem);
    }
}
