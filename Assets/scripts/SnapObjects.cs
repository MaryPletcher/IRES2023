using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnapObjects : MonoBehaviour
{
    public float snapDistance = 0.1f;
    public LayerMask snapLayerMask;

    private bool isSnapped = false;
    private Vector3 initialPosition;
    private Quaternion initialRotation;
    Vector3 offset = new Vector3(.5f, 0f, 0f);

    private void Start()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isSnapped && IsValidSnapTarget(other.gameObject))
        {
            SnapToTarget(other.gameObject);
        }
    }

    private void SnapToTarget(GameObject target)
    {
        // Disable physics for the current cube
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = true;
            rb.useGravity = false;
        }

        // Snap the current cube to the target cube
        transform.SetParent(target.transform);
        transform.position = target.transform.position +offset;
        transform.rotation = target.transform.rotation;

        isSnapped = true;
    }

    private void ResetCube()
    {
        // Reset the cube to its initial position and rotation
        transform.SetParent(null);
        //transform.position = initialPosition;
        //transform.rotation = initialRotation;

        // Enable physics for the cube
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.isKinematic = false;
            rb.useGravity = true;
        }

        isSnapped = false;
    }

    private bool IsValidSnapTarget(GameObject other)
    {
        // Check if the other object has a valid snap target layer
        return (snapLayerMask.value & (1 << other.layer)) > 0;
    }

    private void OnTriggerExit(Collider other)
    {
        if (isSnapped && IsValidSnapTarget(other.gameObject))
        {
            // Release the current cube from the target cube
            ResetCube();
        }
    }
}
