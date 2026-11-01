using UnityEngine;

[CreateAssetMenu(fileName = "PlayerInventory", menuName = "ScriptableObjects/PlayerInventory")]
public class PlayerInventory : ScriptableObject
{
    public static bool doesItemExist = false;
    public static string currentItem;
}
