using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Env3 : MonoBehaviour {
    public Transform[] dizi = new Transform[10];    
    float a = -177.32f;
    float Timer = 0.5f;
    bool mod = false;
    public GameObject engel1, engel2, engel3, engel4,karakter;
    int b;
    // Use this for initialization
    void Start () {
        engel1 = GameObject.Find("Engel");
        engel2 = GameObject.Find("Engel1");
        engel3 = GameObject.Find("Engel2");
        engel4 = GameObject.Find("Engel3");
        

    }

	// Update is called once per frame
	void Update () {
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.N))
        {
            mod = true;
        }
        Timer -= Time.deltaTime;
        if(Timer<=0)
        {
            Uret();
            Timer = 0.5f;
        }
        if(karakter.transform.position.x <-172)
        {
           Destroy(this.GetComponent<Env3>());
        }
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("3");
        foreach (GameObject g in gameObjects)
        {
            if (g.name != "Engel" && g.name != "Engel1" && g.name != "Engel2" && g.name != "Engel3" && g.name != "Kayar10") 
            {
                g.GetComponent<BoxCollider>().enabled = true;
                g.GetComponent<MeshRenderer>().enabled = true;
                g.transform.position = new Vector3(g.transform.position.x + 0.5f, g.transform.position.y, g.transform.position.z);
                if (g.transform.position.x > -85)
                    Destroy(g);
            }
                    }

    }
    void Uret()
    {
        if (mod == false)
            b = Random.Range(1, 5);
        else
            b = Random.Range(0, 5);

        switch (b)
        {
            case 1: Instantiate(engel1);
                break;
            case 2:
                Instantiate(engel2);
                break;
            case 3:
                Instantiate(engel3);
                break;
            case 4:
                Instantiate(engel4);
                break;


        }
    }
}
