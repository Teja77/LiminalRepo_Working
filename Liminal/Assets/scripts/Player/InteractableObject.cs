using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class InteractableObject : MonoBehaviour,IPointerClickHandler
{
    public UnityEvent TriggeredEvent;

    public void OnPointerClick(PointerEventData eventData)
    {
        TriggeredEvent?.Invoke();

         }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
