﻿using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	public int moveSpeed = 10;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Transform tran = transform;
		tran.position = new Vector3(0,0,moveSpeed);
        
		moveSpeed++;
        //transform.Translate(Vector3.forward * moveSpeed*Time.deltatime);
	}
}