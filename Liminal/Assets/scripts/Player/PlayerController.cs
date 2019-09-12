using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Liminal.Core;
using Liminal.SDK.Input;
using Liminal.SDK.VR;
using Liminal.SDK.VR.Input;
using Liminal.Core.Fader;
using Liminal.SDK.VR.Pointers;

public class PlayerController : MonoBehaviour
{
    public IVRInputDevice Device;
    public LayerMask LayerToHit;
    public LayerMask TeleportLayer;
    public float FadeTime;
    public CustomReticule PointerReticulePrefab;

    private Coroutine _teleportRoutine;
    private IVRPointer _Pointer;
    private CustomReticule _Reticule;
    // Start is called before the first frame update
    void Start()
    {
        Device = VRDevice.Device.PrimaryInputDevice;
        _Reticule = Instantiate(PointerReticulePrefab);
    }

    // Update is called once per frame
    void Update()
    {
        if (_Pointer == null) 
        {
            _Pointer = Device.Pointer;
            return;
        }
    
        ReticuleRaycast();

        if (Device.GetButtonDown(VRButton.One))
         {
            MoveRaycast();  
        }
    }

    private void ReticuleRaycast()
    {
        var hitPos = Vector3.zero;

        if (Physics.Raycast(_Pointer.Transform.position, _Pointer.Transform.forward, out RaycastHit hit, 100f, LayerToHit))
        {
            hitPos = hit.point;
        }
        else
        {
            hitPos = _Pointer.Transform.position + (_Pointer.Transform.forward * 15f);
        }

        _Reticule.transform.position = hitPos;
    }

    private void MoveRaycast()
    {
        var pointer = Device.Pointer;

        if (Physics.Raycast(pointer.Transform.position, pointer.Transform.forward, out RaycastHit hit, 100f, TeleportLayer))
        {
           
            if (_teleportRoutine != null)
                return;

            _teleportRoutine = StartCoroutine(TeleportCoro(hit.point));
        }
    }
    


    private IEnumerator TeleportCoro(Vector3 teleportPoint)
    {
        ScreenFader.Instance.FadeToBlack(FadeTime);

        yield return ScreenFader.Instance.WaitUntilFadeComplete();

        transform.position = teleportPoint;
        ScreenFader.Instance.FadeToClear(FadeTime);

        _teleportRoutine = null;
    }
}
