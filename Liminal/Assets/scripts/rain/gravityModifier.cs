using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.SDK.VR.Avatars;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;

public class gravityModifier : MonoBehaviour
{
    private ParticleSystem ps;
    public float SimValue = 0.0f;
    public ParticleSystem.MainModule main;

    private bool _isHandIn;
    private IVRInputDevice _device;

    void Start()
    {
        _device = VRDevice.Device.PrimaryInputDevice;
        ps = GetComponent<ParticleSystem>();
        main = ps.main;
    }
    

    void Update()
    {
        //if (!_isHandIn)
         //   return;
        //
        //if (hand == null)
       ///     return;

        if (!_device.GetButton(VRButton.One))
            return;

        main.simulationSpeed = SimValue;
    }

   // private void OnTriggerEnter(Collider other)
    //{
     //   if (!other.GetComponent<VRAvatarController>())
     //       return;

    //    _isHandIn = true;
   // }

   // private void OnTriggerExit(Collider other)
   // {
    //    if (!other.GetComponent<VRAvatarController>())
    //        return;

    //    _isHandIn = false;
   // }
}