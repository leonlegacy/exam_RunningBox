using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    [SerializeField]
    //CharacterController controller;
    Rigidbody rigi;

    [SerializeField]
    Animator anim;
    

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0f, z);
        
        //controller.Move(new Vector3(x, 0f, z) * speed);
        //rigi.MovePosition
        rigi.velocity = new Vector3(x, rigi.velocity.y, z) * speed;

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
