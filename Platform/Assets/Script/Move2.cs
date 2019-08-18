using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2 : MonoBehaviour {
    Rigidbody rb;
    Vector3 v;
    public int  movespeed;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
        v = new Vector3(Input.GetAxisRaw("Vertical") * movespeed, 0, Input.GetAxisRaw("Horizontal") * movespeed);
        rb.AddForce(v);
	}
}
