using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSnapping : MonoBehaviour
{
    public float snapDistance = 0.5f;
    private bool isSnapped = false;
    private Vector3 originalPosition;

    private void Start()
    {
        originalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isSnapped)
        {
            ObjectSnapping otherSnapping = other.GetComponent<ObjectSnapping>();
            if (otherSnapping != null && !otherSnapping.isSnapped)
            {
                float distance = Vector3.Distance(transform.position, other.transform.position);
                if (distance <= snapDistance)
                {
                    // Snap the objects together
                    transform.position = other.transform.position;
                    transform.rotation = other.transform.rotation;
                    transform.SetParent(other.transform);

                    // Mark both objects as snapped
                    isSnapped = true;
                    otherSnapping.isSnapped = true;
                }
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (isSnapped)
        {
            ObjectSnapping otherSnapping = other.GetComponent<ObjectSnapping>();
            if (otherSnapping != null && otherSnapping.isSnapped)
            {
                // Detach the objects
                transform.SetParent(null);

                // Reset the position to the original position
                transform.position = originalPosition;

                // Mark both objects as not snapped
                isSnapped = false;
                otherSnapping.isSnapped = false;
            }
        }
    }
}
