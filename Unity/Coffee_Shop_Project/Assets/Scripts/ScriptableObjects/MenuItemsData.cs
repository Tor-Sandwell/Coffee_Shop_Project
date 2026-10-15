using UnityEngine;

public enum MenuItems
{
    Espresso,
    Tea,
    IcedCoffee,
    Donut
}

[CreateAssetMenu(fileName = "MenuItemsData", menuName = "Scriptable Objects/MenuItemsData")]
public class MenuItemsData : ScriptableObject
{
    public Ingredients[] ingredients;

}
