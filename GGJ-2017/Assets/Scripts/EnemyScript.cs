﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Rigidbody2D>().AddForceAtPosition (Vector3.forward, new Vector3 (0, 0, 0));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
