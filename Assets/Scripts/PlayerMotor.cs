﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;

    private float speed = 10.0f;
    private float verticalVelocity = 0.0f;
    private float gravity = 12.0f;


	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        moveVector = Vector3.zero;

        if (controller.isGrounded)
        {
            verticalVelocity = -0.05f;
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.x = Input.GetAxisRaw("Horizontal")*speed;
        moveVector.y = verticalVelocity;
        moveVector.z = speed;

        controller.Move(moveVector*Time.deltaTime);
		
	}
}
