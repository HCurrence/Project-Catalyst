using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 1f;

    private Rigidbody rb;
    private Transform transform;

    private InputAction moveAction;
    private InputAction jumpAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform = GetComponent<Transform>();

        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 moveValue = moveAction.ReadValue<Vector2>();

        print(moveValue);

        Vector3 movement = new Vector3(
            transform.forward.x * moveValue.x,
            0f, 
            transform.forward.z * moveValue.y
        ) * velocity;

        transform.Translate(movement);
        //rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
    }
}
