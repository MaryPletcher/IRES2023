using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DebugText : MonoBehaviour
{
    public TMP_Text debugText;
    public Transform otherTransform; // Public variable to reference the other GameObject's Transform

    
    void Update()
    {
        // Access and utilize the other GameObject's Transform
        Vector3 position = otherTransform.position;
        string positionAsString = position.ToString(); 
        // Example: Update the debug text content with some information
        debugText.text = "Hand Position: " + positionAsString;
    }
}