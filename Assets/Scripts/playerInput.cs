using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerInput : MonoBehaviour
{
    MainInputAction mainInputAction;
    Vector2 inputVector2;
    Vector3 movementDirection;

    void Awake()
    {
        mainInputAction = new MainInputAction();
        mainInputAction.Enable();

        mainInputAction.Player.Movement.performed += PlayerMovementInput;
        mainInputAction.Player.Movement.canceled += PlayerMovementInput;
    }

    private void PlayerMovementInput(InputAction.CallbackContext context)
    {
        movementDirection = Vector3.zero;
        inputVector2 = context.ReadValue<Vector2>();
        movementDirection = new Vector3(inputVector2.x,0,inputVector2.y);
    }

    void OnDestroy()
    {
        mainInputAction.Disable();
    }
    void OnDisable()
    {
        mainInputAction.Disable();
    }

    public Vector2 GetPlayerMovementInput() => inputVector2;
    public Vector3 GetPlayerMovementDir() => movementDirection;
}
