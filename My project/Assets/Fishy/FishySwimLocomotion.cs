using UnityEngine;
using easyInputs.TrackedPoser;
using DeviceType = easyInputs.TrackedPoser.DeviceType;
using easyInputs;

[RequireComponent(typeof(Rigidbody))]
public class FishySwimLocomotion : MonoBehaviour
{
    [Header("Rigidbody")]
    public Rigidbody body;
    [Header("Speed")]
    public float SpeedHands = 1;
    public float Speed = 1;
    [Header("Offset")]
    public Transform Offset;
    //Hidden
    bool VibrateL;
    bool VibrateR;
    void Update()
    {
        Vector3 velocityL = Offset.rotation * EasyInputs.GetDeviceVelocity(DeviceType.LeftHand);
        Vector3 velocityR = Offset.rotation * EasyInputs.GetDeviceVelocity(DeviceType.RightHand);
        Vector3 MoveVelocityL = -velocityL / SpeedHands * Speed;
        Vector3 MoveVelocityR = -velocityR / SpeedHands * Speed;
        if (velocityL.magnitude > SpeedHands)
        {
            if (!VibrateL)
            {
                StartCoroutine(EasyInputs.Vibration(EasyHand.LeftHand, 0.2f, 0.15f));
                VibrateL = true;
            }
            body.AddForce(MoveVelocityL, ForceMode.Force);
        }
        else
        {
            VibrateL = false;
        }
        if (velocityR.magnitude > SpeedHands)
        {
            if (!VibrateR)
            {
                StartCoroutine(EasyInputs.Vibration(EasyHand.RightHand, 0.2f, 0.15f));
                VibrateR = true;
            }
            body.AddForce(MoveVelocityR, ForceMode.Force);
        }
        else
        {
            VibrateR = false;
        }
    }
}
