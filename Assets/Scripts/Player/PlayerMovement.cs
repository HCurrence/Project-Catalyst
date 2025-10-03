using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocity = 5f;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(
            Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical")) * velocity;
        rb.linearVelocity = new Vector3(movement.x, rb.linearVelocity.y, movement.z);
    }
}
