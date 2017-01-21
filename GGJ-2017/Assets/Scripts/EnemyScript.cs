﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	float hitPoints;
	const float maxHitPoints = 100.0f;
	public GameObject hpBar;

	// Use this for initialization
	void Start () {
		Vector3 force = -(gameObject.transform.position - new Vector3 (0, 0, 0));
		force.Normalize ();
		hitPoints = maxHitPoints;
		gameObject.GetComponent<Rigidbody>().AddForce (force*EnemyManager.currentEnemySpeed);
	}
	
	// Update is called once per frame
	void Update () {
		hpBar.transform.localScale = new Vector3 (hitPoints / maxHitPoints, 0.1f, 0.1f);
	}

	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Bullet") {
			hitPoints -= GameManager.damageByBullet;
			Debug.Log (hitPoints);
			if (hitPoints <= 0.0f) {
				//Runaway, runaway baby!
				DestroySelf();
			}
		}
	}

	void DestroySelf() {
		Destroy (gameObject);
	}
}
