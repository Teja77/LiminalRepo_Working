using Liminal.SDK.VR.Avatars;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handRotation : MonoBehaviour
{
    public VRAvatarHand Hand;
    // Update is called once per frame
   
    
    public GameObject ObjectToRotate;
    public float MaxRotation = 90f;
    public float MinRotation = 0f;
    public float NormalisedRot;
    Quaternion tempRotate;
    void Update()
    {
      
        var handRotation = Hand.Anchor.rotation;

        /*
        var primaryHand = VRAvatar.Active.PrimaryHand;
        primaryHand.Anchor.Rotation
        */
        ObjectToRotate.transform.rotation = handRotation;

        var rot = ObjectToRotate.transform.localEulerAngles.z;

        rot = Mathf.Clamp(rot, 0, MaxRotation);

        NormalisedRot = rot / MaxRotation;

    }
}
