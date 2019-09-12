using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class growingtree : MonoBehaviour
{
    public float maxGrowthX = 1f;
    public float maxGrowthY = 1f;
    public float maxGrowthZ = 1f;
    public float speedGrowthX = 0.1f;
    public float speedGrowthY = 0.1f;
    public float speedGrowthZ = 0.1f;
    public float maxrotationX = 1f;
    public float maxrotationY = 1f;
    public float maxrotationZ = 1f;
    public float speedRotationX = 0f;
    public float speedRotationY = 0f;
    public float speedRotationZ = 0f;
    public Mesh mesh1;
    public MeshFilter MFilter;
    
    Vector4 changecolor;
    Vector3 tempScale;
    Quaternion tempRotate;

    private void Start()
    {
        //MFilter = GetComponent<MeshFilter>();
    }
    // Update is called once per frame
    void Update()
    {
        tempScale = transform.localScale;
        tempRotate = transform.localRotation;
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
        if (transform.localRotation.x < maxrotationX)
        {
            tempRotate.x += speedRotationX;
            transform.localRotation = tempRotate;
        }
        if (transform.localRotation.y < maxrotationY)
        {
            tempRotate.y += speedRotationY;
            transform.localRotation = tempRotate;
        }
        if (transform.localRotation.z < maxrotationZ)
        {
            tempRotate.z += speedRotationZ;
            transform.localRotation = tempRotate;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            MFilter.mesh = mesh1;
        }
    }
}
