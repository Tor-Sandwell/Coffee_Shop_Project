using UnityEngine;
using System.Collections;
using TMPro;

public class Donut : MonoBehaviour
{
    private GameObject donutClickbox;
    public TextMeshProUGUI currentItemText;
    public TextMeshProUGUI ProgressText;

    public void MakeDonut()
    {
        Debug.Log("MakeDonut() called");
        if (!ItemTracker.doesItemExist)
        {
            ItemTracker.doesItemExist = true;
            StartCoroutine(MakeADonut());
        }
    }
    
    IEnumerator MakeADonut()
    {
        ProgressText.text = "Collecting Donut...";
        ProgressText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        ItemTracker.currentItem = "Donut";
        Debug.Log("ItemTracker.currentItem: " + ItemTracker.currentItem);
        currentItemText.text = "Current Item: " + ItemTracker.currentItem;
        ProgressText.text = "Donut is ready!";
        yield return new WaitForSeconds(.5f);
        ProgressText.gameObject.SetActive(false);
    }
}