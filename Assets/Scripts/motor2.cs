using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class motor2 : MonoBehaviour {

    private Rigidbody myRigid;
    public float speed = 27.0f;

	// Use this for initialization
	void Start () {

        myRigid = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        myRigid.velocity = new Vector3(Input.GetAxis("Horizontal")*speed, myRigid.velocity.y, speed);
		
	}
}
