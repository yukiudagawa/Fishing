using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class DeviceManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (!XRSettings.isDeviceActive)
        {
            Debug.Log("No device detected");
        }
        else
        {
            Debug.Log("Connected to device " + XRSettings.loadedDeviceName);
        }
    }
}
