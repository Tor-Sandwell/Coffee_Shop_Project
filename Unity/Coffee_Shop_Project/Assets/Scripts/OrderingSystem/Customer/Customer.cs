using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class Customer : MonoBehaviour
{
    List<OrderStruct> orderList = new List<OrderStruct>();
    private string _drinkType;
    private int _drinkAmount;
    private bool _orderConfirmed;
    private OrderStruct _item;
    private int _itemsInOrder = 0;
    void Order()
    {
        while (!_orderConfirmed)
        {
            _itemsInOrder ++;
            _item = RandomItem();;
            _orderConfirmed = ConfirmOrder(_itemsInOrder);
            AddItem(_item, _orderConfirmed);
        }
    }
    private OrderStruct RandomItem()
    {
        int quantity = UnityEngine.Random.RandomRange(1, 4);
        OrderStruct returnItem;
        returnItem.Quantity = quantity;
        int itemID = UnityEngine.Random.RandomRange(0, 4);
        switch (itemID)
        {
            case 0:
            returnItem.ItemName = "esspresso";
            break;
            case 1:
            returnItem.ItemName = "tea";
            break;
            case 2:
            returnItem.ItemName = "iced coffee";
            break;
            case 3:
            returnItem.ItemName = "donut";
            break;
            default:
            returnItem.ItemName = "";
            break;
        }
        return returnItem;
    }
    private bool ConfirmOrder(int itemsInOrder)
    {
        itemsInOrder += UnityEngine.Random.Range(0,5);

        if (itemsInOrder >= 3)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void AddItem(OrderStruct orderItem, bool orderConfimed)
    {
        orderList.Add(orderItem);
        if (orderConfimed)
        {
            foreach (OrderStruct orderedItem in orderList)
            {
                Debug.Log(orderedItem.ItemName + " " + orderedItem.Quantity);
            }
        }
    }
    void Start()
    {
        Order();
    }
}