using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using OculusSampleFramework;

/*
public class VRReplenishableObject : MonoBehaviour
{
    public float respawnDelay = 3f; // Delay before the object respawns
    private bool isGrabbed = false;
    private Vector3 originalPosition;
    private Quaternion originalRotation;
    private Transform originalParent;
    private OVRGrabbable grabbable;

    private void Start()
    {
        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalParent = transform.parent;

        // Get the OVRGrabbable component from the object
        grabbable = GetComponent<OVRGrabbable>();
        if (grabbable != null)
        {
            grabbable.onGrab.AddListener(OnGrabbed);
            grabbable.onRelease.AddListener(OnReleased);
        }
    }

    private void OnGrabbed(OVRGrabber grabber)
    {
        if (!isGrabbed)
        {
            isGrabbed = true;
            gameObject.SetActive(false); // Hide the object

            // Start the respawn timer
            Invoke("RespawnObject", respawnDelay);
        }
    }

    private void OnReleased(OVRGrabber grabber)
    {
        // Cancel the respawn timer if the object is released early
        if (isGrabbed)
        {
            isGrabbed = false;
            CancelInvoke("RespawnObject");
        }
    }

    private void RespawnObject()
    {
        isGrabbed = false;
        transform.position = originalPosition;
        transform.rotation = originalRotation;
        transform.SetParent(originalParent);
        gameObject.SetActive(true); // Show the object again
    }
}
*/