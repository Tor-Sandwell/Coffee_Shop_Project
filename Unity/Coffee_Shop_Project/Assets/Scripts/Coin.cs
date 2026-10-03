using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public static int coinsCollected;
    public TMP_Text coinText;
    bool coinCollected = false;
    public void OnTriggerEnter(Collider other)
    {
        if (coinCollected == false)
        {
            Debug.Log("Coin Collected");
            coinCollected = true;
            coinsCollected++;
            if(coinsCollected == 1)
            {
                coinText.SetText("1/3");
            }
            else if(coinsCollected == 2)
            {
                coinText.SetText("2/3");
            }
            else if(coinsCollected == 3)
            {
                coinText.SetText("3/3");
            }
        }
    }
}