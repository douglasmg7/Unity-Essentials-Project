using UnityEngine;

public class DayNightCycleRotation : MonoBehaviour
{
    public float secondsPerDay = 60f; // Editable variable in the Inspector window

    void Update()
    {
        float anglePerSecond = 360f / secondsPerDay;
        float angleChange = Time.deltaTime * anglePerSecond;

        transform.Rotate(Vector3.right, angleChange);
    }
}