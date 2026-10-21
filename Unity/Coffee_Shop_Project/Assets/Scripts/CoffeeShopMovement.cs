using UnityEngine;
using UnityEngine.InputSystem;

public class CoffeeShopMovement : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 5.5f;
    [SerializeField] private float runSpeed = 9f;

    [SerializeField] private float gravity = 9.81f;

    [SerializeField] private float cameraSensitivity = 0.2f;
    [SerializeField] private float cameraAngleLimit = 70f;

    private float ySpeed;

    private Camera mainCamera;
    private CharacterController characterController;

    private InputAction moveInput;
    private InputAction runInput;

    private InputAction jumpInput;
    private bool jumped = false;

    private float currentMoveSpeed = 0.0f;
    private Vector3 moveDirection = Vector3.zero;
    private float cameraAngle = 0.0f;

    private void Start()
    {
        transform.Rotate(0, 0, 0);
        mainCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();

        moveInput = InputSystem.actions.FindAction("Move");
        runInput = InputSystem.actions.FindAction("Sprint");

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        currentMoveSpeed = walkSpeed;
    }

    private void Update()
    {
        Vector2 moveVector = moveInput.ReadValue<Vector2>();
        Vector2 mouseDelta = new Vector2(Mouse.current.delta.x.ReadValue(), Mouse.current.delta.y.ReadValue());

        if (!characterController.isGrounded)
        {
            jumped = false;
        }
        currentMoveSpeed = runInput.IsPressed() ? runSpeed : walkSpeed;
        HandleMovement(moveVector);
        HandleCamera(mouseDelta);
    }

    private void HandleMovement(Vector2 moveVector)
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);

        float oldY = moveDirection.y;

        Vector2 newSpeed = new Vector2(moveVector.y * currentMoveSpeed, moveVector.x * currentMoveSpeed);

        moveDirection = (forward * newSpeed.x) + (right * newSpeed.y);
        moveDirection.y = oldY;

        if (!characterController.isGrounded)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        characterController.Move(moveDirection * Time.deltaTime);
    }

    private void HandleCamera(Vector2 mouseDelta)
    {
        cameraAngle += -mouseDelta.y * cameraSensitivity;
        cameraAngle = Mathf.Clamp(cameraAngle, -cameraAngleLimit, cameraAngleLimit);

        mainCamera.transform.localRotation = Quaternion.Euler(cameraAngle, 0, 0);
        transform.rotation *= Quaternion.Euler(0, mouseDelta.x * cameraSensitivity, 0);
    }
}
