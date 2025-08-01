using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToAppear : MonoBehaviour
{
    public GameObject targetObject; // Assign the object to appear in the Inspector

    void Start()
    {
        // Ensure the target object is initially hidden
        if (targetObject != null)
        {
            targetObject.SetActive(false);
        }
    }

    void OnMouseDown() // This function is called when the collider is clicked
    {
        if (targetObject != null)
        {
            targetObject.SetActive(true); // Make the target object visible
        }
    }
}