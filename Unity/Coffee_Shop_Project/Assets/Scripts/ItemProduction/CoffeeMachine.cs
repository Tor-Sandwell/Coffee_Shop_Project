using UnityEngine;
using System.Collections;
using TMPro;

public class CoffeeMachine : MonoBehaviour
{
    private GameObject coffeeMachineClickbox;
    public TextMeshProUGUI currentItemText;
    public TextMeshProUGUI ProgressText;
    public void MakeCoffee()
    {
        if (!ItemTracker.doesItemExist)
        {
            ItemTracker.doesItemExist = true;
            StartCoroutine(MakeACoffee());
        }
    }
    
    IEnumerator MakeACoffee()
    {
        ProgressText.text = "Making Coffee...";
        ProgressText.gameObject.SetActive(true);  
        yield return new WaitForSeconds(3.5f);
        ItemTracker.currentItem = "Espresso";
        currentItemText.text = "Current Item: " + ItemTracker.currentItem;
        ProgressText.text = "Coffee is ready!";
        yield return new WaitForSeconds(.5f);
        ProgressText.gameObject.SetActive(false);
    }
}