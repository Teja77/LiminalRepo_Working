using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDim : MonoBehaviour
{
    // Interpolate light color between two colors back and forth
    float duration = 1.0f;
    public float Hill;
    public float End;


    Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    void Update()
    {
        // set light color
        float t = Time.deltaTime/2;
        lt.intensity = Mathf.Clamp (Hill, End, t);
    }
}
