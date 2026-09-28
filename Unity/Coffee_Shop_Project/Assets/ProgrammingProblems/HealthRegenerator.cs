using System.Collections;   
using UnityEngine;
using System.Collections.Generic;  
public class HealthRegenerator : MonoBehaviour
{
    private int maxHealth = 100;
    private int currentHealth = 50;

    void Start()
    {
        StartCoroutine(HealthRegen());
    }

    public int MaxHealth
    {
        get
        {
            return MaxHealth;
        }
    }
    public int CurrentHealth
    {
        get
        {
            return CurrentHealth;
        }
        set
        {
            CurrentHealth = value;
        }
    }

    IEnumerator HealthRegen()
    {
        while (CurrentHealth > MaxHealth)
        {
            yield return new WaitForSeconds(1);
            HealthRegenerator.CurrentHealth ++;
            Debug.Log("current health: " + HealthRegenerator.CurrentHealth);
        }
    }
}