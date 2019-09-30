using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wetness : MonoBehaviour
{
    public Material Material;
    public float RainDelta;
    public float multiplier = 1f;
    public float MaxRainAmount;
    public float MaxRippleAmount;
    private float _curRainVal;
    private float _curRippleVal;

    private void OnParticleCollision(GameObject other)
    {
        _curRainVal = Material.GetFloat("Vector1_FC03E501");
        _curRippleVal = Material.GetFloat("Vector1_A87DE66");
        _curRippleVal = Mathf.Clamp(_curRippleVal + (RainDelta * multiplier), 0f, MaxRippleAmount); ;
        _curRainVal = Mathf.Clamp(_curRainVal + (RainDelta * multiplier), 0f, MaxRainAmount);
        Material.SetFloat("Vector1_FC03E501", _curRainVal);
        Material.SetFloat("Vector1_A87DE66", _curRippleVal);

    }
}
