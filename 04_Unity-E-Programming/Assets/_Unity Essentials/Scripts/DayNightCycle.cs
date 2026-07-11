using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("The time in real-world seconds it takes to complete a full 24-hour cycle.")]
    public float dayDurationInSeconds = 120f; // Default is 2 minutes for quick testing

    void Update()
    {
        // Prevent division by zero errors if the duration is accidentally set to 0
        if (dayDurationInSeconds <= 0f) return;

        // A full day is 360 degrees. 
        // 360 / duration = degrees to rotate per second.
        float rotationSpeed = 360f / dayDurationInSeconds;

        // Rotate around the X-axis based on the time passed since the last frame
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}