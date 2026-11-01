using UnityEngine;
using System.Collections;

public class CoffeeMachine : MonoBehaviour
{
    [SerializeField] private PlayerInventory playerInventory;
    void MakeCoffee()
    {
        // bool itemExistence = playerInventory.doesItemExist;
        // if (doesItemExist == false)
        // {
        //     doesItemExist == true;
        //     StartCoroutine(MakeACoffee());
        // }
    }
    
    IEnumerator MakeACoffee()
    {
        Debug.Log("coffee started");
        yield return new WaitForSeconds(3.5f);
        Debug.Log("Coffee Finished");
    }
}
