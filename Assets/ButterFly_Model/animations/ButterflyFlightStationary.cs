using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButterflyFlightStationary : MonoBehaviour
{
    public Transform topLeftWing;
    public Transform topRightWing;
    public Transform bottomLeftWing;
    public Transform bottomRightWing;

    public float flapSpeed = 5f;             // Speed of wing flapping
    public float flapAngle = 30f;            // Max flap rotation in degrees
    public float hoverAmplitudeY = 0.1f;     // Vertical hover amount
    public float hoverAmplitudeX = 0.05f;    // Horizontal sway (optional)
    public float hoverSpeed = 1f;            // Speed of hovering

    private float startTime;
    private Vector3 originalPosition;

    void Start()
    {
        startTime = Time.time;
        originalPosition = transform.position;
    }

    void Update()
    {
        // Wing flapping animation
        float flap = Mathf.Sin((Time.time - startTime) * flapSpeed);
        float wingRotation = flap * flapAngle;

        if (topLeftWing != null)
            topLeftWing.localRotation = Quaternion.Euler(0f, 0f, wingRotation);
        if (bottomLeftWing != null)
            bottomLeftWing.localRotation = Quaternion.Euler(0f, 0f, wingRotation);
        if (topRightWing != null)
            topRightWing.localRotation = Quaternion.Euler(0f, 0f, -wingRotation);
        if (bottomRightWing != null)
            bottomRightWing.localRotation = Quaternion.Euler(0f, 0f, -wingRotation);

        // Gentle hovering motion
        float hoverY = Mathf.Sin((Time.time - startTime) * hoverSpeed) * hoverAmplitudeY;
        float hoverX = Mathf.Sin((Time.time - startTime) * hoverSpeed * 0.5f) * hoverAmplitudeX; // optional sway

        transform.position = originalPosition + new Vector3(hoverX, hoverY, 0f);
    }
}
