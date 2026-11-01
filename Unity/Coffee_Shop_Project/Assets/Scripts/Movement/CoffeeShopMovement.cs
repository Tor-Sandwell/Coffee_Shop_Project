using UnityEngine;
using UnityEngine.InputSystem;

public class CoffeeShopMovement : MonoBehaviour
{
    [SerializeField] private float cameraSensitivity = 0.2f;
    [SerializeField] private float cameraAngleLimit = 70f;

    private Camera mainCamera;
    private CharacterController characterController;

    private float cameraAngle = 0.0f;

    private void Start()
    {
        transform.Rotate(0, 0, 0);
        mainCamera = GetComponentInChildren<Camera>();

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 mouseDelta = new Vector2(Mouse.current.delta.x.ReadValue(), Mouse.current.delta.y.ReadValue());

        HandleCamera(mouseDelta);
    }

    private void HandleCamera(Vector2 mouseDelta)
    {
        cameraAngle += -mouseDelta.y * cameraSensitivity;
        cameraAngle = Mathf.Clamp(cameraAngle, -cameraAngleLimit, cameraAngleLimit);


        mainCamera.transform.localRotation = Quaternion.Euler(cameraAngle, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseDelta.x * cameraSensitivity, 0);
    }
}