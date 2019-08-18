using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float movespeed;
    public float gravitys;
    public float jumpforce;
    public CharacterController ch;
    private Vector3 direction;
    public Transform pivot;
    public Camera c;
    float prevx = 0, prevz = 0, nowx, nowz, farkx, farkz;
    public Transform asd;
    public Vector3 Base= new Vector3(2, 1, -5);
    
    // Use this for initialization
    void Start () {
        ch = GetComponent<CharacterController>();
        Cursor.visible = false;
	}
	public static class GlobalVariable
    {
        public static Transform check;
    }
	// Update is called once per frame
	void Update () {
        float saved = direction.y;
        direction = (pivot.transform.forward * Input.GetAxisRaw("Vertical") * movespeed) + (pivot.transform.right * Input.GetAxisRaw("Horizontal") * movespeed);
        direction = direction.normalized * movespeed;
        direction.y = saved;
       

        nowx = ch.transform.position.x ;nowz = ch.transform.position.z;
       
       if (ch.isGrounded)
        {
            direction.y = 0f;
            if (Input.GetButtonDown("Jump"))
            {
                direction.y = jumpforce;
            }
            
        }

        farkx =Mathf.Abs(nowx - prevx);
        farkz =Mathf.Abs(nowz - prevz);
        

     if(Input.GetKey(KeyCode.W))
        {
            if(farkx>farkz)
            {if((nowx-prevx)<0)
                ch.transform.Rotate(Input.GetAxis("Horizontal") * 1000*Time.deltaTime, 0, Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(-Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);

            }
           else if(farkz>farkx)
            {
                if ((nowz - prevz) < 0)
                    ch.transform.Rotate(-Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
            }
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (farkx > farkz)
            {
                if ((nowx - prevx) < 0)
                    ch.transform.Rotate(-Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);

            }
            else if (farkz > farkx)
            {
                if ((nowz - prevz) < 0)
                    ch.transform.Rotate(Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(-Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (farkx > farkz)
            {
                if ((nowx - prevx) < 0)
                    ch.transform.Rotate(-Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);

            }
            else if (farkz > farkx)
            {
                if ((nowz - prevz) < 0)
                    ch.transform.Rotate(Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0,Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(-Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
            }

        }
        if (Input.GetKey(KeyCode.D))
        {
            if (farkx > farkz)
            {
                if ((nowx - prevx) < 0)
                    ch.transform.Rotate(Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(-Input.GetAxis("Vertical") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, Space.World);

            }
            else if (farkz > farkx)
            {
                if ((nowz - prevz) < 0)
                    ch.transform.Rotate(-Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, -Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
                else
                    ch.transform.Rotate(Input.GetAxis("Horizontal") * 1000 * Time.deltaTime, 0, Input.GetAxis("Vertical") * 1000 * Time.deltaTime, Space.World);
            }

        }

        if (transform.position.y < -1)
        {
            transform.position = Base;
        }

        direction += gravitys * Time.deltaTime * Physics.gravity;
        
        ch.Move(direction * Time.deltaTime);
        prevx = nowx;
        prevz = nowz;
       
       
	}
}
