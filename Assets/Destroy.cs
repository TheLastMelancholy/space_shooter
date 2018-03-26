using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnTriggerExit(Collider OtherObject)
    {
        Destroy(OtherObject.gameObject);
    }
}
