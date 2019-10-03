using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Snow2 : MonoBehaviour
{
    public Material Material;
    public Material Material1;
    public Material Material2;
    public Material Material3;
    public float SnowDelta;
    public float multiplier = 1f;
    public float MaxSnowAmount;
   
    public AudioSource Source;
    public float AudioDelay;
    public bool IsPlayingAudio;

    private Coroutine _audioRoutine;
    private float _curSnowVal;


    private void OnEnable()
    {
        if(_audioRoutine!=null)
        {
            StopCoroutine(_audioRoutine);
        }

        if (_curSnowVal > MaxSnowAmount)
            return;

        IsPlayingAudio = true;

        _audioRoutine = StartCoroutine(AudioCoro());
    }

    private IEnumerator AudioCoro()
    {
        yield return new WaitForSeconds(AudioDelay);
        Source.Play();
    }

    private void OnDisable()
    {
        if (_audioRoutine != null)
        {
            StopCoroutine(_audioRoutine);
        }

        IsPlayingAudio = false;
    }

    private void OnParticleCollision(GameObject other)
    {
        _curSnowVal = Material.GetFloat("Vector1_D5319A04");
     
        _curSnowVal = Mathf.Clamp(_curSnowVal + (SnowDelta* multiplier), 0f, MaxSnowAmount);
        Material.SetFloat("Vector1_D5319A04", _curSnowVal);
        Material1.SetFloat("Vector1_F5FDBD7C", _curSnowVal);
        Material2.SetFloat("Vector1_87AA5796", _curSnowVal);
        Material3.SetFloat("Vector1_AE5F8890", _curSnowVal);
        
        RenderSettings.fog = false;
    }
}
