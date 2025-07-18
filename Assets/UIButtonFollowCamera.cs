using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtonFollowCamera : MonoBehaviour
{
    public Camera mainCamera; // Assign in Inspector or auto-find
    public Vector3 offset;

    void LateUpdate()
    {
        if (mainCamera == null)
        {
            mainCamera = Camera.main; // Try to find the main camera automatically
            if (mainCamera == null)
            {
                Debug.LogError("Main camera not found! Please assign it manually.");
                return; // Exit if no camera found
            }
        }

        // Now safe to use mainCamera
        transform.position = mainCamera.transform.position + mainCamera.transform.rotation * offset;
        transform.rotation = Quaternion.LookRotation(transform.position - mainCamera.transform.position);
    }
}
