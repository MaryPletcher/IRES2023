using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetainOriginalPosition : MonoBehaviour
{
    private Vector3 originalPosition;
    private Quaternion originalRotation;

    private void Start()
    {
        // Store the original position and rotation of the object
        originalPosition = transform.position;
        
    }

    private void Update()
    {
        // Check if the object has moved or rotated away from its original transformation
        if (transform.position != originalPosition || transform.rotation != originalRotation)
        {
            // Reset the object's position and rotation to the original values
            transform.position = originalPosition;
            
        }
    }
}
