using UnityEngine;
using TMPro;

public class Bin : MonoBehaviour
{
    public TextMeshProUGUI currentItemText;

    public void BinItem()
    {
        if (ItemTracker.doesItemExist)
        {
            ItemTracker.doesItemExist = false;
            ItemTracker.currentItem = "";
            currentItemText.text = "Current Item: ";
        }
    }
}
