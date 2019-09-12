using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightning : MonoBehaviour
{
    public GameObject lit;
    // Start is called before the first frame update
    void Start()
    {
      
    }

   

    private void OnParticleCollision(GameObject other)
    {
        if(other.layer == 10)
        {
            //Destroy(other.gameObject);
            GetComponent<AudioSource>().Play();
            //lit.gameObject.GetComponent<Animator>().SetTrigger("Lightning");


            
        }
    }
}
