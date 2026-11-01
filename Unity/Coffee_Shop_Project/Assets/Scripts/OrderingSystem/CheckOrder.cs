using UnityEngine;
using TMPro;
using System.Collections;

public class CheckOrder : MonoBehaviour
{
    public int orderNumber = 0;

    [SerializeField] private NPCSpawner npcSpawner;
    [SerializeField] private Renderer npcMesh;
    [SerializeField] private Collider NPCClickbox;
    [SerializeField] private GameObject Reset;

    public TextMeshProUGUI currentOrderText;
    public TextMeshProUGUI currentItemText;
    public TextMeshProUGUI orderNumberText;
    public TextMeshProUGUI FeedbackText;

    public void orderCheck()
    {
        if(npcSpawner.orderActive == true)
        {
            if (ItemTracker.currentItem == ItemTracker.currentOrder)
            {
                orderNumber++;
                orderNumberText.text = "Customers Completed: " + orderNumber + "/3";
                npcSpawner.orderActive = false;
                ItemTracker.doesItemExist = false;
                ItemTracker.currentItem = "";
                ItemTracker.currentOrder = "";
                currentOrderText.text = "Current Order: ";
                currentItemText.text = "Current Item: ";

                if (orderNumber < 3)
                {  
                    npcSpawner.CustomerSpawner();
                    FeedbackText.color = Color.green;
                    FeedbackText.text = "Order Completed!";
                    StartCoroutine(FeedbackTextCoroutine());
                }
                else
                {
                    npcMesh.enabled = false;
                    NPCClickbox.enabled = false;
                    FeedbackText.text = "All Orders Completed!";
                    FeedbackText.color = Color.green;
                    FeedbackText.gameObject.SetActive(true);
                    Reset.SetActive(true);
                }

            }
            else
            {
                ItemTracker.doesItemExist = false;
                ItemTracker.currentItem = "";
                currentItemText.text = "Current Item: ";
                FeedbackText.text = "Incorrect or missing Order!";
                FeedbackText.color = Color.red;
                StartCoroutine(FeedbackTextCoroutine());

            }
        }
        else
        {
            npcSpawner.StartOrder();
        }
    }

    IEnumerator FeedbackTextCoroutine()
    {
        FeedbackText.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        FeedbackText.gameObject.SetActive(false);
    }
}