using UnityEngine;
using UnityEngine.Events;
using System.Collections.Generic;
using TMPro;

public class CreateOrder : MonoBehaviour
{
    private OrderStruct _item;
    private int _orderNumber = 0;

    public  TextMeshProUGUI currentOrderText;

    [SerializeField] private NPCSpawner npcSpawner;
    [SerializeField] private MenuItems menuItems;

    [SerializeField] private GameObject CoffeeMachine;
    [SerializeField] private GameObject ColaMachine;
    [SerializeField] private GameObject Cake;
    [SerializeField] private GameObject Donut;

    public void Order() 
    {
        _orderNumber++;
        _item = RandomItem();
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
        currentOrderText.text = "Current Order: " + orderItem.ItemName;
        switch (orderItem.ItemName)
        {
            case "Espresso":
                Debug.Log("test0");
                ItemTracker.currentOrder = "Espresso";
                CoffeeMachine.SetActive(true);
                break;
            case "Cola":
                ItemTracker.currentOrder = "Cola";
                ColaMachine.SetActive(true);
                break;
            case "Cake":
                ItemTracker.currentOrder = "Cake"; 
                Cake.SetActive(true);
                break;
            case "Donut":
                ItemTracker.currentOrder = "Donut";
                Donut.SetActive(true);
                break;
            default:
            Debug.Log(orderItem.ItemName);
                ItemTracker.currentOrder = "";
                break;
        }
    }
}