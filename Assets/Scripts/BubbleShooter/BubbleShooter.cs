using NUnit.Framework;
using System;
using UnityEngine;

public class BubbleShooter : MonoBehaviour
{
    [SerializeField]
    public BubbleManager bubbleManager;
    [SerializeField]
    public float rotationFOV = 180.0f;
    [SerializeField]
    public GameObject ballOut;
    [SerializeField]
    public float sensitivity = 1.0f;

    private List ammo;
    private GameObject currentAmmo;
    private Vector3 ammoPos;

    private Quaternion rotationZ;
    private Vector3 shootDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammoPos = ballOut.transform.position;
        shootDirection = ballOut.transform.up;

        ammo = bubbleManager.bubblesInChamber;
        currentAmmo = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        // Get mouse pos in world space
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float mouseZ = transform.position.z - Camera.main.transform.position.z;

        // For vertical rotation (around X-axis), clamping to prevent flipping
        float rotationAngle = Vector3.SignedAngle(transform.up, new Vector3(mouseX, mouseY, mouseZ), Vector3.forward);
        print(rotationAngle);
        rotationAngle = Mathf.Clamp(rotationAngle, -(rotationFOV / 2f), (rotationFOV / 2f));

        transform.RotateAround(transform.position, Vector3.forward, rotationAngle);
    }
}