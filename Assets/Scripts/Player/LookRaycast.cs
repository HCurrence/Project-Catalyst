using UnityEngine;
using UnityEngine.InputSystem;

public class LookRaycast : MonoBehaviour
{
    Transform cameraPos;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cameraPos = GetComponentInChildren<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;

        if(Physics.Raycast(cameraPos.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.DrawRay(cameraPos.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.green);
        }
        else
        {
            Debug.DrawRay(cameraPos.position, transform.TransformDirection(Vector3.forward) * 1000, Color.red);
        }
    }
}
