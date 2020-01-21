using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject[] animals;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject randomAnimal = animals[Random.Range(0, animals.Length)];
            Instantiate(randomAnimal, transform.position, transform.rotation);
        }
	}
}
