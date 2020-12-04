using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    CharacterController control;
    Animator anim;
    Vector3 moveDirection = Vector3.zero;

    public float speed = 0.25f;
    public float rotSpeed = 80;
    public float gravity = 8;
    float rot = 0;
    void Start()
    {
        control = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = new Vector3(0, 0, 5 * speed * Time.deltaTime);
            moveDirection *= speed;
            anim.SetInteger("walk", 1);
            //transform.position += moveDirection;
            moveDirection = transform.TransformDirection(moveDirection);


        }
        else
        {
            moveDirection = new Vector3(0, 0, 0);
            anim.SetInteger("walk", 0);
        }

        rot += Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rot, 0);
        moveDirection.y -= gravity * Time.deltaTime;
        control.Move(moveDirection * Time.deltaTime);
    }
}

