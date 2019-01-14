using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float movespeed;
	
	void Start () {
        movespeed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
        
            transform.Translate(movespeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movespeed * Input.GetAxis("Vertical") * Time.deltaTime);
       
	}
}
