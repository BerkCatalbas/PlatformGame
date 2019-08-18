using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Env2 : MonoBehaviour {

    public Transform[] dizi = new Transform[10];
    bool geri = false;
    float a = -45.85f, b = -45.85f, c = -45.85f, d= -45.85f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        dizi[4].transform.Rotate(-100 * Time.deltaTime, 0, 0);
        dizi[5].transform.Rotate(50 * Time.deltaTime, 0, 0);
        dizi[6].transform.Rotate(-50 * Time.deltaTime, 0, 0);
        dizi[7].transform.Rotate(100 * Time.deltaTime, 0, 0);
        if (dizi[0].position.x < -35f && geri == false)
        {

            dizi[0].position = new Vector3(a, dizi[0].position.y, dizi[0].position.z);
            dizi[1].position = new Vector3(c, dizi[1].position.y, dizi[1].position.z);
            dizi[2].position = new Vector3(b, dizi[2].position.y, dizi[2].position.z);
            dizi[3].position = new Vector3(d, dizi[3].position.y, dizi[3].position.z);
            a = a + 0.1f;
            b = b - 0.1f;
            c = c + 0.05f;
            d = d - 0.05f;
        }
       else if (dizi[0].position.x > -35f)
            geri = true;

        if (dizi[0].position.x > -57f && geri == true)
        {
            dizi[0].position = new Vector3(a, dizi[0].position.y, dizi[0].position.z);
            dizi[1].position = new Vector3(c, dizi[1].position.y, dizi[1].position.z);
            dizi[2].position = new Vector3(b, dizi[2].position.y, dizi[2].position.z);
            dizi[3].position = new Vector3(d, dizi[3].position.y, dizi[3].position.z);
            a = a - 0.1f;
            b = b + 0.1f;
            c = c - 0.05f;
            d = d + 0.05f;

        }

        else if (dizi[0].position.x < -57f)
            geri = false;

    }
}
