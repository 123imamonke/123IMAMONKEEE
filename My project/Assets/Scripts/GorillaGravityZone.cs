using GorillaLocomotion;
using UnityEngine;

public class GorillaGravityZone : MonoBehaviour
{
    private void Awake() => gameObject.layer = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other == Player.Instance.bodyCollider)
        {
            Debug.Log("Entered gravity zone");
            Player.Instance.GetComponent<Rigidbody>().useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other == Player.Instance.bodyCollider)
        {
            Debug.Log("Exited gravity zone");
            Player.Instance.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}