using UnityEngine;

public class UIButtonFollowCamera : MonoBehaviour
{
    void LateUpdate()
    {
        Camera cam = Camera.main;
        if (cam == null)
            return;

        Vector3 direction = cam.transform.position - transform.position;

        // Avoid zero vector error
        if (direction != Vector3.zero)
        {
            // Optional: make only the Y axis rotate (useful for 2D or top-down games)
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = lookRotation;
        }
    }
}
