using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplecollision : MonoBehaviour

{

    public GameObject Activate;
    // Start is called before the first frame update
    void Start()
    {
        Activate.gameObject.SetActive(false);
        Debug.Log(Activate.name + "deactivated");
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player"))
        {
            Activate.gameObject.SetActive(true);
            gameObject.transform.tag = "destroy";

        }
    }
}

