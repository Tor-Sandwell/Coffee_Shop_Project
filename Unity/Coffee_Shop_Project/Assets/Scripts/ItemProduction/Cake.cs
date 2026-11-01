using UnityEngine;
using System.Collections;
using TMPro;

public class Cake : MonoBehaviour
{
    private GameObject cakeMachineClickbox;
    public TextMeshProUGUI currentItemText;
    public TextMeshProUGUI ProgressText;
    public void MakeCake()
    {
        Debug.Log("MakeCake() called");
        if (!ItemTracker.doesItemExist)
        {
            ItemTracker.doesItemExist = true;
            StartCoroutine(MakeACake());
        }
    }
    
    IEnumerator MakeACake()
    {
        ProgressText.text = "Collecting Cake...";
        ProgressText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        ItemTracker.currentItem = "Cake";
        Debug.Log("ItemTracker.currentItem: " + ItemTracker.currentItem);
        currentItemText.text = "Current Item: " + ItemTracker.currentItem;
        ProgressText.text = "Cake is ready!";
        yield return new WaitForSeconds(.5f);
        ProgressText.gameObject.SetActive(false);
    }
}