using UnityEngine;

[CreateAssetMenu(fileName = "CoffeeShopData", menuName = "ScriptableObjects/CoffeeShopData")]
public class CoffeeShopData : ScriptableObject
{
    public float money;
    public Sprite moneyIcon;
    public MenuData menu;
}