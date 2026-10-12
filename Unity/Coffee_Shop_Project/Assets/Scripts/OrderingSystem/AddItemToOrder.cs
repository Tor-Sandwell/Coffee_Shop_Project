using UnityEngine;
using System.Collections.Generic;

public class AddItemToOrder : MonoBehaviour
{
    List<OrderStruct> orderList = new List<OrderStruct>();
    public void AddItem(OrderStruct orderItem)
    {
        orderList.Add(orderItem);
    }
}