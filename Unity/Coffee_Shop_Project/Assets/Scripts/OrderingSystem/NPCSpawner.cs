using UnityEngine;
using System.Collections;

public class NPCSpawner : MonoBehaviour
{

    [SerializeField] private Renderer npcMesh;
    [SerializeField] private Collider NPCClickbox;
    [SerializeField] private GameObject npcObject;
    
    public bool orderActive = false;
    
    private CreateOrder createOrder;

    void Awake()
    {
        createOrder = GetComponent<CreateOrder>();
        npcMesh = GetComponent<Renderer>();
        npcMesh.enabled = false;
        NPCClickbox.enabled = false;
        StartCoroutine(SpawnCustomer());
    }

    public void CustomerSpawner()
    {
        StartCoroutine(SpawnCustomer());
    }

    IEnumerator SpawnCustomer()
    {
        NPCClickbox.enabled = false;
        yield return new WaitForSeconds(1f);
        npcMesh.enabled = false;
        yield return new WaitForSeconds(1.5f);
        npcMesh.enabled = true;
        NPCClickbox.enabled = true;
    }

    public void StartOrder()
    {
        if (!orderActive)
        {
            createOrder.Order();
            orderActive = true; 
        }
    }
}