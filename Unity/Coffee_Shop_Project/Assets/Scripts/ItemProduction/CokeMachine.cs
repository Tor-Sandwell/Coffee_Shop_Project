using UnityEngine;
using System.Collections;
using TMPro;

public class CokeMachine : MonoBehaviour
{
    private GameObject cokeMachineClickbox;
    public TextMeshProUGUI currentItemText;
    public TextMeshProUGUI ProgressText;
    public void MakeCoke()
    {
        Debug.Log("MakeCoke() called");
        if (!ItemTracker.doesItemExist)
        {
            ItemTracker.doesItemExist = true;
            StartCoroutine(MakeACoke());
        }
    }
    
    IEnumerator MakeACoke()
    {
        ProgressText.text = "Making Coke...";
        ProgressText.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        ItemTracker.currentItem = "Cola";
        Debug.Log("ItemTracker.currentItem: " + ItemTracker.currentItem);
        currentItemText.text = "Current Item: " + ItemTracker.currentItem;
        ProgressText.text = "Coke is ready!";
        yield return new WaitForSeconds(.5f);
        ProgressText.gameObject.SetActive(false);
    }
}