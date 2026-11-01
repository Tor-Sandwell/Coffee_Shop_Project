using UnityEngine;

[CreateAssetMenu(fileName = "MenuItems", menuName = "ScriptableObjects/MenuItems")]
public class MenuItems : ScriptableObject
{
    public string item0 = "Espresso";
    public string item1 = "Cola";
    public string item2 = "Cake";
    public string item3 = "Donut";
    public float item0Price = 2.99f;
    public float item1Price = 1.99f;
    public float item2Price = 2.49f;
    public float item3Price = 2.99f;
}
