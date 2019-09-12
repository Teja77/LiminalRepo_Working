using System.Collections;
using System.Collections.Generic;
using Liminal.SDK.VR.Avatars;
using UnityEngine;
using UnityEngine.EventSystems;

public class RainController : BaseInteractiveObject
{
    public VRAvatarHand Hand;
    public gravityModifier GravModifier;
    public float MaxRotation = 90f;
    public float MinRotation = 0f;
    public float NormalisedRot;
    public bool IsActive;
    

    public override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);
        IsActive = true;
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        base.OnPointerUp(eventData);
        IsActive = false;
    }

    void Update()
    {
        if (!IsActive)
            return;

        if (Hand == null || GravModifier == null)
            return;
      
        var handRotation = Hand.Anchor.rotation;
      
        handRotation.y = transform.rotation.y;
        handRotation.x = transform.rotation.x;
        transform.rotation = handRotation;

        var rot = transform.localEulerAngles.z;
        rot = Mathf.Clamp(rot, 0, MaxRotation);

        NormalisedRot = rot / MaxRotation;

        GravModifier.SimValue = NormalisedRot;
    }
}
