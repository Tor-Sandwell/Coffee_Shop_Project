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
        HealthRegenerator healthRegenerator = new HealthRegenerator();
        currentHealth = healthRegenerator.CurrentHealth;
        maxHealth = healthRegenerator.MaxHealth;
        while(currentHealth < maxHealth)
        {
            yield return new WaitForSeconds(1);
            healthRegenerator.CurrentHealth = CurrentHealth + 1;
            Debug.Log("current health: " + healthRegenerator.CurrentHealth);
            currentHealth ++;
        }
    }
}