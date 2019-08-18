using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Env : MonoBehaviour {
    public Transform[] dizi=new Transform[10];   
    float a = 33.3f,b=33.3f,c=33.3f;
    bool geri=false;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
        dizi[0].transform.Rotate(-50*Time.deltaTime, 0, 0);

        if (dizi[1].position.z < 40.3f && geri ==false)
        {
            
            dizi[1].position=new Vector3(dizi[1].position.x, dizi[1].position.y, a);
            dizi[2].position = new Vector3(dizi[2].position.x, dizi[2].position.y, b);
            dizi[3].position = new Vector3(dizi[3].position.x, dizi[3].position.y, c);
            a =a+0.1f;
            b = b - 0.1f;
            c = c + 0.05f;
        }
        if (dizi[1].position.z > 40.3f)
            geri = true;
        
        if (dizi[1].position.z > 23.3f && geri == true)
        {
            dizi[1].position = new Vector3(dizi[1].position.x, dizi[1].position.y, a);
            dizi[2].position = new Vector3(dizi[2].position.x, dizi[2].position.y, b);
            dizi[3].position = new Vector3(dizi[3].position.x, dizi[3].position.y, c);
            a = a - 0.1f;
            b = b + 0.1f;
            c = c - 0.05f;

        }
        
        else if (dizi[1].position.z < 23.3f)
            geri = false;


    }
}
