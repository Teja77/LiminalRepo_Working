using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Envi : MonoBehaviour
{
    public GameObject lit;
    public float TimeBetweenLightning = 10f;
    public float Delay = 3f;
    public bool IsActive = true;
    private Coroutine timerRoutine;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    private void OnEnable()
    {
        IsActive = true;
        timerRoutine = StartCoroutine(TimerCoro());
    }

    private IEnumerator TimerCoro()
    {
        yield return new WaitForSeconds(Delay);
        lit.gameObject.GetComponent<Animator>().SetTrigger("Lightning");

        while (IsActive)
        {
            var elapsedTime = 0f;

            while (elapsedTime < TimeBetweenLightning)
            {
                elapsedTime += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }

            lit.gameObject.GetComponent<Animator>().SetTrigger("Lightning");

            yield return new WaitForEndOfFrame();
        }
    }

    private void OnDisable()
    {
        IsActive = false;
        if (timerRoutine != null)
        {
            StopCoroutine(timerRoutine);
        }
    }
}
