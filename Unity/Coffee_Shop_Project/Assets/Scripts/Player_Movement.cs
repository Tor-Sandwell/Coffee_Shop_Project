using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public CharacterController controller;
    private float speed = 4f;
    

    private float sensitivity = 2.5f;
    private float limitforrotation = 70f;
    private Vector2 rotation = Vector2.zero;
    private Camera mainCamera;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        mainCamera = Camera.main;
    }

    private bool isGrounded()
    {
        return controller.isGrounded;
    }
    public void Update()
    {
        Vector3 move = new Vector3(Input.GetAxisRaw("Horizontal") * Time.deltaTime, 0, Input.GetAxisRaw("Vertical") * Time.deltaTime);

        if (isGrounded() && Input.GetKey(KeyCode.Space))
        {
            move.y = 5f * Time.deltaTime;
        }

        //jumping and gravity

        move = this.transform.TransformDirection(move);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 6f;
        }
        else
        {
            speed = 4f;
        }           
        controller.Move(move * speed);                                             

        rotation.x += Input.GetAxis("Mouse X") * sensitivity;
        rotation.y += Input.GetAxis("Mouse Y") * sensitivity;
        rotation.y = Mathf.Clamp(rotation.y, -limitforrotation, limitforrotation);

        var xQuat = Quaternion.AngleAxis(rotation.x, Vector3.up);
        var yQuat = Quaternion.AngleAxis(rotation.y, Vector3.left) * Quaternion.Euler(0, 180, 0);

        mainCamera.transform.localRotation = Quaternion.AngleAxis(rotation.y, Vector3.zero) * yQuat * Quaternion.Euler(0, 180, 0);

        transform.localRotation = Quaternion.AngleAxis(rotation.x, Vector3.zero) * xQuat;


    }
}
