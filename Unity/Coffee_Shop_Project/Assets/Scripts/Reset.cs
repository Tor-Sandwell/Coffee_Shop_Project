using UnityEngine;
using TMPro;

public class Reset : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentOrderText;
    [SerializeField] private TextMeshProUGUI currentItemText;
    [SerializeField] private TextMeshProUGUI orderNumberText;
    [SerializeField] private TextMeshProUGUI FeedbackText;
    [SerializeField] private TextMeshProUGUI ProgressText;
    [SerializeField] private NPCSpawner npcSpawner;
    [SerializeField] private CheckOrder checkOrder;
    [SerializeField] private GameObject ResetButton;

    public void GameReset()
    {
        ItemTracker.doesItemExist = false;
        ItemTracker.currentItem = "";
        ItemTracker.currentOrder = "";
        npcSpawner.orderActive = false;
        checkOrder.orderNumber = 0;
        currentOrderText.text = "Current Order: ";
        currentItemText.text = "Current Item: ";
        orderNumberText.text = "Customers Completed: 0/3";
        ResetButton.SetActive(false);
        FeedbackText.gameObject.SetActive(false);
        ProgressText.gameObject.SetActive(false);
        npcSpawner.CustomerSpawner();
    }
}