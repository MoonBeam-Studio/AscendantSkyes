using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : MonoBehaviour
{
    private bool IsMoving;
    private PlayerMovementController playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovementController>();
    }
    public void OnMovement(InputAction.CallbackContext value)
    {
        Vector2 moveInput = value.ReadValue<Vector2>();
        if(value.performed && !IsMoving)
        {
            playerMovement.SetMovementInput(moveInput);
            IsMoving = true;
        }
        else if(value.canceled && IsMoving)
        {
            playerMovement.SetMovementInput(Vector2.zero);
            IsMoving= false;
        }
    }
}
