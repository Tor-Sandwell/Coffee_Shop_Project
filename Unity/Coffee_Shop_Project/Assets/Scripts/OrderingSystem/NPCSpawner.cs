using UnityEngine;
using System.Collections;

public class NPCSpawner : MonoBehaviour
{

    [SerializeField] private Renderer npcMesh;
    [SerializeField] private GameObject npcObject;
    
    private CreateOrder createOrder;

    void Wake()
    {
        createOrder = GetComponent<CreateOrder>();
        npcMesh = GetComponent<Renderer>();
        npcMesh.enabled = false;
        StartCoroutine(SpawnCustomer());
    }

    public void CustomerSpawner()
    {
        StartCoroutine(SpawnCustomer());
    }

    IEnumerator SpawnCustomer()
    {
        yield return new WaitForSeconds(1f);
        npcMesh.enabled = false;
        yield return new WaitForSeconds(1.5f);
        npcMesh.enabled = true;
        createOrder.Order();
    }
}