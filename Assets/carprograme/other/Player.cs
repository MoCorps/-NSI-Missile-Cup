using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Unity.Cinemachine;
using Unity.VisualScripting;
using System;

public class Player : MonoBehaviour
{
    [SerializeField] CinemachineVirtualCameraBase MainCam;
    [SerializeField] CinemachineVirtualCameraBase SeconCam;

    private void OnEnable()
    {
        CameraSwitcher.Register(MainCam);
        CameraSwitcher.Register(SeconCam);
        CameraSwitcher.SwitchCamera(MainCam);
    }
private void OnDisable()
    {
        CameraSwitcher.Unregister(MainCam);
        CameraSwitcher.Unregister(SeconCam);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Y))
        {
            //Switch Camera
            if(CameraSwitcher.IsActiveCamera(MainCam))
            {
                CameraSwitcher.SwitchCamera(SeconCam);
            }
        }
    }

    internal List<Player> ToList()
    {
        throw new NotImplementedException();
    }
}
