using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class snow1 : MonoBehaviour
{
    public Material Material;
    public float SnowDelta;
    public float multiplier = 1f;

    private void Start()
    {
        var curSnowVal = Material.GetFloat("Vector1_D5319A04");
        Material.SetFloat("Vector1_D5319A04", curSnowVal);
        // Materialtoadd.SetFloat("Vector1_D5319A04", snowValue/maxValue);
    }

    void OnParticleCollision(GameObject other)
    {
        var curSnowVal = Material.GetFloat("Vector1_D5319A04");
        curSnowVal = Mathf.Clamp(curSnowVal - (SnowDelta * multiplier), 0, 1f);
        Material.SetFloat("Vector1_D5319A04", curSnowVal);
    }
}
