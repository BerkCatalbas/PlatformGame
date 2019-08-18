using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariable : MonoBehaviour {
    public int checkzone=1;
   public AudioSource a;
    
	// Use this for initialization
	void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        
        if ((Input.GetKey(KeyCode.RightControl) || Input.GetKey(KeyCode.LeftControl)) && Input.GetKeyDown(KeyCode.T))
        {
            if (a.mute == true)
                a.mute = false;
            else
                a.mute = true;
        }
    }
}
