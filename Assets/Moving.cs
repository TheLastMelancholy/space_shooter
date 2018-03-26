using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMax, zMax, xMin, zMin;
}

public class Moving : MonoBehaviour {

    // Use this for initialization
    float MoveXaxis = 0, MoveYaxis = 0, Axeleration = 1;
    public float AxelerationMultiplyer;
    public Boundary boundary;
    public float tilt;
    public GameObject Shot;
    public Transform ShotSpawn;

    public float fireRate;
    private float nextFire = 0.0f;

    void Start () {
	}
	
	// Update is called once per frame

        void Update()
    {

        if (Input.GetKey(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(Shot, ShotSpawn.position, ShotSpawn.rotation);
        }


    }

	void FixedUpdate () {
       MoveXaxis = Input.GetAxis("Horizontal")*0.1f;
       MoveYaxis = Input.GetAxis("Vertical")*0.1f;


        if (Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0) Axeleration = 1;
        else if(Axeleration <=3) Axeleration *=AxelerationMultiplyer;

        transform.position = new Vector3(Mathf.Clamp(transform.position.x + MoveXaxis * Axeleration, boundary.xMin, boundary.xMax),
                                          transform.position.y,
                                          Mathf.Clamp(transform.position.z + MoveYaxis * Axeleration, boundary.zMin, boundary.zMax));
        transform.rotation = Quaternion.Euler(0f, 0f, MoveXaxis*Axeleration * -tilt);
	}
}
