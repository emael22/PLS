using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour {

    private CharacterController controller;
    private Vector3 moveVector;

    public float speed = 27.0f;
    private float verticalVelocity = 0.0f;
    private float gravity;


	// Use this for initialization
	void Start () {

        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {

        //moveVector = Vector3.zero;

        moveVector.x = Input.GetAxis("Horizontal")*speed; 

        controller.Move(moveVector*Time.deltaTime);
		
	}
}
