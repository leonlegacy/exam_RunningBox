using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    [SerializeField]
    Rigidbody rigi;

    [SerializeField]
    Animator anim;
    

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0f, z);
        
        rigi.velocity = new Vector3(x * speed, rigi.velocity.y, z * speed);

        if (direction != Vector3.zero)
            transform.forward = direction;
    }

    private void FixedUpdate()
    {
        if (rigi.velocity != Vector3.zero)
            anim.SetBool("IsRunning", true);
        else
            anim.SetBool("IsRunning", false);
    }
}
