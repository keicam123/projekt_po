using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// script added for testing and learning puproses, will not be a part of final project

public class playermovement : MonoBehaviour
{
    public CharacterController2D controller;
    void start()
    {

    }
    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal")* runSpeed;

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
