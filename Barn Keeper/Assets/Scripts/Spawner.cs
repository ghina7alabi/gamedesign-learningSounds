using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject wolfPrefab;

    // Use this for initialization
    void Start () {
        InvokeRepeating("spawnWolf", 1, 3);
	}
	

    void spawnWolf()
    {
        Instantiate(wolfPrefab, transform.position, transform.rotation);
    }
}
