using UnityEngine;
using UnityEngine.EventSystems;

public class BaseInteractiveObject 
    : MonoBehaviour
    , IPointerClickHandler
    , IPointerDownHandler
    , IPointerUpHandler
{
    public virtual void OnPointerClick(PointerEventData eventData)
    {

    }

    public virtual void OnPointerDown(PointerEventData eventData)
    {

    }

    public virtual void OnPointerUp(PointerEventData eventData)
    {

    }
}
