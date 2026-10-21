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
    private int _itemsInOrder;
    public float orderCost;
    public float customerCoins;
    private float tip;
    [SerializeField] private MenuItems menuItems;

    void Order()
    {
        orderList.Clear();
        customerCoins = UnityEngine.Random.Range(6f, 15f);
        customerCoins *= 100;
        customerCoins = Mathf.Round(customerCoins);
        customerCoins /= 100;
        _itemsInOrder = 0;
        _orderConfirmed = false;
        orderCost = 0f;
        while (!_orderConfirmed)
        {
            _itemsInOrder ++;
            _item = RandomItem(orderCost);
            _orderConfirmed = ConfirmOrder(_itemsInOrder);
            orderCost = _item.ItemCost;
            AddItem(_item, _orderConfirmed, orderCost, customerCoins);
        }

    }
    private OrderStruct RandomItem(float _orderCost)
    {
        int quantity = UnityEngine.Random.Range(1, 4);
        OrderStruct returnItem;
        returnItem.Quantity = quantity;
        int itemID = UnityEngine.Random.Range(0, 4);
        switch (itemID)
        {
            case 0:
            returnItem.ItemName = menuItems.item0;
            returnItem.ItemCost = _orderCost + menuItems.item0Price * quantity;
            break;
            case 1:
            returnItem.ItemName = menuItems.item1;
            returnItem.ItemCost = _orderCost + menuItems.item1Price * quantity;
            break;
            case 2:
            returnItem.ItemName = menuItems.item2;
            returnItem.ItemCost = _orderCost + menuItems.item2Price * quantity;
            break;
            case 3:
            returnItem.ItemName = menuItems.item3;
            returnItem.ItemCost = _orderCost + menuItems.item3Price * quantity;
            break;
            default:
            returnItem.ItemName = "";
            returnItem.ItemCost = _orderCost + 0f;
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

    public void AddItem(OrderStruct orderItem, bool orderConfimed, float _orderCost, float customerCoins)
    {
        orderList.Add(orderItem);
        if (orderConfimed)
        {
            if (willTip())
            {
                tip = UnityEngine.Random.Range(_orderCost/20, _orderCost/5);
                tip *= 100;
                tip = Mathf.Round(tip);
                tip /= 100;
            }
            if (customerCoins > orderCost)
            {
                foreach (OrderStruct orderedItem in orderList)
                {
                    Debug.Log(orderedItem.ItemName + " x " + orderedItem.Quantity);
                }
                Debug.Log("Price " + _orderCost);
                Debug.Log("tip " + tip);
            }
            else
            {
                Debug.Log("customer does not have enough coins");
            }
        }
    }

    private bool willTip()
    {
        int temp = UnityEngine.Random.Range(0, 4);
        if (temp == 0)
        {
            return true;
        }
        return false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Order();
        }
    }
}