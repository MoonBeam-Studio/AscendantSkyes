using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector2 movementInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (movementInput == null || movementInput == Vector2.zero) return;
        rb.angularVelocity = 
    }

    public void SetMovementInput(Vector2 input) => movementInput = input;
}
