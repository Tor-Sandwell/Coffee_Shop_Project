using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    float speed = 0.01f;
    float jumpHeight = 0.5f;
    bool BoostAtive = false;

    void Update()
    {
        if (speed == 0.02f)
        {
            Debug.Log("Speed Boost Active");
        }
        if (Input.GetKey(KeyCode.U))//forward
        {
            Forward(transform.position, speed);
        }
        if (Input.GetKey(KeyCode.H))//left
        {
            Left(transform.position, speed);
        }
        if (Input.GetKey(KeyCode.J))//backward
        {
            Backward(transform.position, speed);
        }
        if (Input.GetKey(KeyCode.Y))//right
        {
            Right(transform.position, speed);
        }
        if (Input.GetKey(KeyCode.Space))//up
        {
            if (GetComponent<Rigidbody>().linearVelocity.y == 0)
            {
                Jump(transform.position, jumpHeight);
            }
        }
    }
    void Forward(Vector3 position, float speed)
    {
        transform.position = new Vector3(position.x, position.y, position.z + speed);
    }
    void Left(Vector3 position, float speed)
    {
        transform.position = new Vector3(position.x - speed, position.y, position.z);  
    }
    void Backward(Vector3 position, float speed)
    {
        transform.position = new Vector3(position.x, position.y, position.z - speed);
    }
    void Right(Vector3 position, float speed)
    {
        transform.position = new Vector3(position.x + speed, position.y, position.z);
    }
    void Jump(Vector3 position, float jumpHeight)
    {
        transform.position = new Vector3(position.x, position.y + jumpHeight, position.z);
    }
}
