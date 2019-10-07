using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDim : MonoBehaviour
{

    public Light lt;
    public float max;
    private float startTime;
    // Use this for initialization
    void Start()
    {
        lt = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
        LightIntensity();
    }
    private void OnEnable()
    {
        startTime = Time.time;
    }

    void LightIntensity()
    {
        
        lt.intensity = Mathf.Lerp(0f, max, (Time.time- startTime) / 30);
        Debug.Log("LightIntensity =" + lt.intensity + Time.time);
    }
}