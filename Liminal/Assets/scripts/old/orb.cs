using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orb : MonoBehaviour
{
    public float maxGrowthX = 1f;
    public float maxGrowthY = 1f;
    public float maxGrowthZ = 1f;
    public float speedGrowthX = 0.1f;
    public float speedGrowthY = 0.1f;
    public float speedGrowthZ = 0.1f;
 

    Vector3 tempScale;
    

    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        tempScale = transform.localScale;
   
        if (transform.localScale.x < maxGrowthX)
        {
            tempScale.x += speedGrowthX;
            transform.localScale = tempScale;
        }
        if (transform.localScale.y < maxGrowthY)
        {
            tempScale.y += speedGrowthY;
            transform.localScale = tempScale;
        }
        if (transform.localScale.z < maxGrowthZ)
        {
            tempScale.z += speedGrowthZ;
            transform.localScale = tempScale;
        }
    }
}
