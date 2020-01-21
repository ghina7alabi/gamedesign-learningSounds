using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour {
    
    public int speed;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * speed;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

}
