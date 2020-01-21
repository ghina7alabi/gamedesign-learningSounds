using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfMovement : MonoBehaviour {

    float toPosX;
    float toPosY;
    float time;

    

	// Use this for initialization
	void Start () {
        toPosX = Random.Range(-4, 5);
        toPosY = Random.Range(-4, 4);
        time = Random.Range(1, 4);


        iTween.MoveTo(this.gameObject, iTween.Hash(
                                                    "x", toPosX,
                                                    "y", toPosY,
                                                    "time", time,
                                                    "easetype", "linear",
                                                    "looptype", "pingPong",
                                                    "onComplete", "FlipSprite"));

        if(this.gameObject.transform.position.x > toPosX)
        {
            FlipSprite();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void FlipSprite()
    {
        if(this.gameObject.GetComponent<SpriteRenderer>().flipX == false)
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else
        {
            this.gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Animal")
        {
            this.gameObject.GetComponent<AudioSource>().Play();
            iTween.ShakePosition(Camera.main.gameObject, new Vector3(1, 0, 0), 0.25f);
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }

    
}
