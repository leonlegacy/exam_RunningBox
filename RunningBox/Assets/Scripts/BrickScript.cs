using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;

    public Vector3 targetPosition = Vector3.zero;

    [SerializeField]
    bool canMove = false;

    private void FixedUpdate()
    {
        if (canMove)
        {
            transform.rotation = Quaternion.identity;
            transform.localPosition = Vector3.MoveTowards(transform.localPosition, targetPosition, speed);

        }
        if (transform.localPosition == targetPosition)
        {
            canMove = false;
            Destroy(this);
        }
            
    }

    public void setTargetPosition(Vector3 _target, Transform _newParent)
    {
        transform.parent = _newParent;
        targetPosition = _target;
        canMove = true;
    }
}
