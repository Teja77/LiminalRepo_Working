using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomReticule : MonoBehaviour
{
    public Camera Cam;
    public float ObjectScale = 1.0f;
    public Vector3 InitialScale;

    // set the initial scale, and setup reference camera
    void Start()
    {
        // record initial scale, use this as a basis
        InitialScale = transform.localScale;

        // if no specific camera, grab the default camera
        if (Cam == null)
            Cam = Camera.main;
    }

    // scale object relative to distance from camera plane
    void Update()
    {
        Plane plane = new Plane(Cam.transform.forward, Cam.transform.position);
        float dist = plane.GetDistanceToPoint(transform.position);
        transform.localScale = InitialScale * dist * ObjectScale;
    }
}
