using UnityEngine;

public class VATCalculator : MonoBehaviour
{
    public float VATCalculation(float itemPrice)
    {
        if (itemPrice > 0)
        {
            itemPrice = itemPrice * 1.2f;
            
        }
        Debug.LogWarning("Item Price must be more than zero");
        return itemPrice; 
    }
}