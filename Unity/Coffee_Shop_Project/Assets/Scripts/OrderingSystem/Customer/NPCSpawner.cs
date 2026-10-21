using UnityEngine;

public class NPCSpawner : MonoBehaviour
{
    [SerializeField] private CapsuleCollider npcHitbox;
    [SerializeField] private Renderer npcMesh;
    [SerializeField] private GameObject npcObject;

    public void npcSpawner()
    {
        npcMesh = GetComponent<Renderer>();
        npcHitbox = GetComponent<CapsuleCollider>();

        npcHitbox.enabled = false;
        npcMesh.enabled = false;
    }

    void Start()
    {
        npcSpawner();
    }
}
