using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;

public class CreateOrder : MonoBehaviour
{
    private OrderStruct _item;
    private int _orderNumber = 0;
    [SerializeField] private NPCSpawner npcSpawner;
    [SerializeField] private MenuItems menuItems;

    public void Order() 
    {
        _orderNumber++;
        _item = RandomItem();
        string testLog = _item.ItemName;
        SendOrder(_item);
    }

    private OrderStruct RandomItem()
    {
        OrderStruct returnItem;
        int itemID = UnityEngine.Random.Range(0, 4);
        switch (itemID)
        {
            case 0:
            returnItem.ItemName = menuItems.item0;
            returnItem.ItemCost = menuItems.item0Price;
            break;
            case 1:
            returnItem.ItemName = menuItems.item1;
            returnItem.ItemCost = menuItems.item1Price;
            break;
            case 2:
            returnItem.ItemName = menuItems.item2;
            returnItem.ItemCost = menuItems.item2Price;
            break;
            case 3:
            returnItem.ItemName = menuItems.item3;
            returnItem.ItemCost = menuItems.item3Price;
            break;
            default:
            returnItem.ItemName = "";
            returnItem.ItemCost = 0f;
            break;
        }
        return returnItem;
    }

    void SendOrder(OrderStruct orderItem)
    {
        if (_orderNumber < 3)
        {
            npcSpawner.CustomerSpawner();
        }
        Debug.Log(orderItem.ItemName);
    }
}