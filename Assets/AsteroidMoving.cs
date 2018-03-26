using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMoving : MonoBehaviour {

    public float MaxRotation;

    void Start()
    {
        Rigidbody RotatingModel = GetComponent(typeof (Rigidbody)) as Rigidbody;
        RotatingModel.angularVelocity = Random.insideUnitSphere*MaxRotation;

    }
}
