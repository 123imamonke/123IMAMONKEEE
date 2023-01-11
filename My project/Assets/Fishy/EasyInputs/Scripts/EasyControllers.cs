using easyInputs;
using easyInputs.TrackedPoser;
using UnityEngine;
using DeviceType = easyInputs.TrackedPoser.DeviceType;

public class EasyControllers : MonoBehaviour
{
    public DeviceType type;

    void Update()
    {
        transform.localPosition = EasyInputs.GetDevicePosition(type);
        transform.localRotation = EasyInputs.GetDeviceRotation(type);
    }
}
