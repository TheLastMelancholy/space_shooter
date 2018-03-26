using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingByScript_ect : MonoBehaviour {

    public GameObject Explosion;
    public GameObject ExplosionPlayer;
    public GameObject Particle;

	void OnTriggerEnter(Collider OtherObject)
    {
        if (OtherObject.tag == "Boundary" || OtherObject.tag=="Asteroid") return;
        if (OtherObject.tag == "Player")
        {
            Instantiate(ExplosionPlayer, OtherObject.transform.position, OtherObject.transform.rotation);
        }
            Instantiate(Explosion, transform.position, transform.rotation);

        for (int i = 0; i < Random.Range(0f, 3f); i++) {
            Instantiate(Particle, this.transform.position+Random.insideUnitSphere, this.transform.rotation); }
        

        Destroy(OtherObject.gameObject);
            Destroy(this.gameObject);
    }
}
