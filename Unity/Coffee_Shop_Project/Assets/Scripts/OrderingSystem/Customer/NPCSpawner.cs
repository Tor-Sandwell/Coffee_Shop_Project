using UnityEngine;
using System.Collections;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField] private CapsuleCollider npcHitbox;
    [SerializeField] private Renderer npcMesh;
    [SerializeField] private GameObject npcObject;
    
    private CreateOrder createOrder;

    void Start()
    {
        createOrder = GetComponent<CreateOrder>();
        npcMesh = GetComponent<Renderer>();
        npcHitbox = GetComponent<CapsuleCollider>();
        npcHitbox.enabled = false;
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
        npcHitbox.enabled = false;
        npcMesh.enabled = false;
        yield return new WaitForSeconds(1.5f);
        npcHitbox.enabled = true;
        npcMesh.enabled = true;
        createOrder.Order();
    }
}