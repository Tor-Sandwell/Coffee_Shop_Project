using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class CustomMovement : MonoBehaviour
{
    [SerializeField] private float baseSpeed;
    [SerializeField] private float runSpeedMutl;
    [SerializeField] private float baseJumpForce;
    [SerializeField] private float gravity;
    [SerializeField] private float cameraSensitivity;
    [SerializeField] private float cameraAngleLimit;

    private Camera mainCamera;
    private CharacterController characterController;

    private InputAction moveInput;
    private InputAction runInput;
    private float currentMoveSpeed;
    private bool isRunning;

    private InputAction jumpInput;
    private bool isJumping;

    private Vector3 playerSpeed;

    private void Start()
    {
        mainCamera = GetComponentInChildren<Camera>();
        characterController = GetComponent<CharacterController>();

        moveInput = InputSystem.actions.FindAction("Move");
        runInput = InputSystem.actions.FindAction("Move");

        jumpInput = InputSystem.actions.FindAction("Jump");

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        currentMoveSpeed = baseSpeed;
    }

    private void Update()
    {
        Vector2 moveDirection = moveInput.ReadValue<Vector2>();
        
    }
}
