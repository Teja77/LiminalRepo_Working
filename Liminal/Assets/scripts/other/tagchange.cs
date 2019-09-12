using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tagchange : MonoBehaviour
{
    
    private Ray ray;
    private RaycastHit hit;

    void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, Mathf.Infinity) && Input.GetMouseButtonDown(0))
        {

            if (hit.collider.gameObject.tag == "new")
            {
                hit.collider.gameObject.tag = "interact";
            }
        }
    }
}
