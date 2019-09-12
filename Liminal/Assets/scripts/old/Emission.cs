using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emission : MonoBehaviour
    
{
    public ParticleSystem SparkleSystem;
    public float EmissionTime;
    private Coroutine _stopRoutine;
    // Start is called before the first frame update
    void Start()
    {
        var emission = SparkleSystem.emission;
        emission.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "entered");
        var emission = SparkleSystem.emission;
        emission.enabled = true;

        if (_stopRoutine == null)
            _stopRoutine = StartCoroutine(stopSparkle());
    }
    
  IEnumerator stopSparkle()
    {
        yield return new WaitForSeconds(EmissionTime);
        var emission = SparkleSystem.emission;
        emission.enabled = false;
        //EmissionTime = WaitForSeconds;
        _stopRoutine = null;
    }
}
