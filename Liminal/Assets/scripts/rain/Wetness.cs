using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wetness : MonoBehaviour
{
    public Material Material;
    public float RainDelta;
    public float multiplier = 1f;
    public float MaxRainAmount;
    private float _curRainVal;

    private void OnParticleCollision(GameObject other)
    {
        _curRainVal = Material.GetFloat("Vector1_A87DE66");
        _curRainVal = Mathf.Clamp(_curRainVal + (RainDelta * multiplier), 0f, MaxRainAmount);
        Material.SetFloat("Vector1_A87DE66", _curRainVal);
    }
}
