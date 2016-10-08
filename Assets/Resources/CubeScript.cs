﻿using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

    public float rotateSpeed = 1.0f;
    Vector3 spinSpeed = Vector3.zero;
    Vector3 spinAxis = new Vector3(0, 1, 0);


    // Use this for initialization
    void Start () {

        //this.transform.position = new Vector3(0, 5, 3);
        //SetSize(2.0f);


        spinSpeed = new Vector3(0f, Random.value, 0f);
        spinAxis = Vector3.up;
        //spinAxis.x = (Random.value - Random.value) * .1f;

	
	}
		
	// Update is called once per frame
	void Update () {

        
      
	
	}

	public void SpinBaby(){
		
		this.transform.Rotate(spinSpeed);
		// this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);
	}
	public void SetSize(float size)
	{
		this.transform.localScale = new Vector3(size, size, size);
	}
}