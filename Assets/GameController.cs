using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject Hazard;
    public Vector3 SpawnValues;
    public int HazardCount;
    public float SpawnWait;
    public float StartWait;

void Start()
    {
        StartCoroutine( SpawnWaves());

    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(StartWait);
        for (int i = 0; i < HazardCount; i++)
        {
            Vector3 SpawnPosition = new Vector3();
            SpawnPosition = SpawnValues;
            SpawnPosition.x = Random.Range(-6.0f, 6.0f);
            Quaternion SpawnRotation = Quaternion.identity;
            Instantiate(Hazard, SpawnPosition, SpawnRotation);
            yield return new WaitForSeconds (SpawnWait);
        }

    }
}
