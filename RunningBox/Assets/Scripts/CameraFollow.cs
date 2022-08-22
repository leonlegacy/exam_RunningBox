using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    Transform target;

    [SerializeField]
    float smoothSpeed = 0.125f;

    [SerializeField]
    Vector3 offset;

    private void FixedUpdate()
    {
        Vector3 smoothPosition = Vector3.Lerp(transform.position, target.position + offset, smoothSpeed);
        transform.position = smoothPosition;
    }
}
