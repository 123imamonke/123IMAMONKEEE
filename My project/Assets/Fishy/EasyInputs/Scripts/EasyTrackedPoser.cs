namespace easyInputs.TrackedPoser
{
    using UnityEngine;

    public enum TransformType
    {
        RotationOnly,
        PositionOnly,
        RotationAndPosition
    }

    public class EasyTrackedPoser : MonoBehaviour
    {
        public DeviceType Device;
        public TransformType type = TransformType.RotationAndPosition;

        void Update()
        {
            if (type == TransformType.RotationAndPosition)
            {
                transform.localPosition = EasyInputs.GetDevicePosition(Device);
                transform.localRotation = EasyInputs.GetDeviceRotation(Device);
            } else if (type == TransformType.PositionOnly)
            {
                transform.localPosition = EasyInputs.GetDevicePosition(Device);
            } else if (type == TransformType.RotationOnly)
            {
                transform.localRotation = EasyInputs.GetDeviceRotation(Device);
            }
        }
    }
}