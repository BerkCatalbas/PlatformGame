using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour {
    public Transform obj;
    private Vector3 offset;
    public float rotatespeed;
    public Transform pivot;
    
    // Use this for initialization
    void Start () {
        offset = obj.transform.position - transform.position;
        
        
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        pivot.transform.position = obj.transform.position;
        
        float hori = Input.GetAxis("Mouse X")*rotatespeed;
        pivot.Rotate(0,hori , 0);
        
        float vert = Input.GetAxis("Mouse Y") * rotatespeed;
        pivot.Rotate(-vert, 0, 0);

        if(pivot.rotation.eulerAngles.x>45f&& pivot.rotation.eulerAngles.x<180f)
      {
           pivot.rotation = Quaternion.Euler(45f,pivot.eulerAngles.y,pivot.eulerAngles.z);
       }
        if(pivot.rotation.eulerAngles.x>180f&&pivot.rotation.eulerAngles.x<315f)
        {
            pivot.rotation = Quaternion.Euler(315f, pivot.eulerAngles.y, pivot.eulerAngles.z);
        }

        float xangle =pivot.eulerAngles.x;
        float yangle = pivot.eulerAngles.y;        
        Quaternion rotation = Quaternion.Euler(xangle, yangle, 0);
        transform.position = obj.position - (rotation * offset);
        if(transform.position.y<obj.position.y)
        {
             transform.position = new Vector3(transform.position.x, obj.position.y, transform.position.z);
            

        }
        transform.LookAt(obj);
	}
}
