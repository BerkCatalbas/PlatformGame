using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public GameObject global;
    public GameObject Basepoint;
    public GlobalVariable scriptvalue;
    public Move scriptdeger;
    public int a;
    private int c = 1;
    public Transform character;
    public AudioSource fireworks;
    public AudioSource a2;
    public ParticleSystem firework;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (this.transform.position.x+2 > character.transform.position.x  && c == 1)
        {
            scriptvalue = global.GetComponent<GlobalVariable>();
            a = scriptvalue.checkzone;
            if(a==3)
            {
                firework.Play();
                fireworks.Play();
                a2.mute = true;
            }
            GameObject[] gameObjects = GameObject.FindGameObjectsWithTag(a.ToString());

            foreach (GameObject g in gameObjects)
                GameObject.Destroy(g);
            a++;
            scriptvalue.checkzone++;
            Debug.Log(scriptvalue.checkzone);
            c++;
            scriptdeger = Basepoint.GetComponent<Move>();
            scriptdeger.Base = new Vector3(this.transform.position.x, this.transform.position.y + 5, this.transform.position.z);
             gameObjects = GameObject.FindGameObjectsWithTag(a.ToString());
            foreach (GameObject g in gameObjects)
                g.GetComponent<MeshRenderer>().enabled = true;
            
                
            
        }
    }
}
