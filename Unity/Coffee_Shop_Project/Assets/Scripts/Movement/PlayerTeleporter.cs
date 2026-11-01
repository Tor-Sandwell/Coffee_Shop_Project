using UnityEngine;
using System.Collections;

public class PlayerTeleporter : MonoBehaviour
{
    private static bool isMoving = false;
    public void TeleportPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        Vector3 targetPos = this.transform.position;
        StartCoroutine (MovePlayer(targetPos, player));
    }

    IEnumerator MovePlayer(Vector3 targetPos, GameObject player)
    {
        if (isMoving == false)
        {
            isMoving = true;
            Vector3 moveVector = 0.01f *(targetPos - player.transform.position);
            moveVector.y = 0;
            for(int i = 0; i <100; i++)
            {
                player.transform.position += moveVector;
                yield return new WaitForSeconds(.005f);
            }
            isMoving = false;
        }
    } 
}