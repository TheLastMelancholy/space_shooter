using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMover : MonoBehaviour {

    public float speed;
	// Use this for initialization
	void Start () {
        Rigidbody ThisPhysics = GetComponent(typeof(Rigidbody)) as Rigidbody;
        ThisPhysics.velocity = transform.forward*speed;
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
