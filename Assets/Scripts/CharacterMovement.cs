using UnityEngine;
using System.Collections;
using System;

public class CharacterMovement : MonoBehaviour {
	
	public Animator anim = null;
	private bool movementUp = false;
    private Vector3 lastPosition = new Vector3();
    public GameObject player;
	
	/*// Use this for initialization
	void Start () {
		// = gameObject.GetComponent<Animator> ();
        //Physics2D.IgnoreCollision(player.collider2D, this.collider2D);
	}
	// Update is called once per frame
	void FixedUpdate () {
        //transform.position = player.transform.position;
        //Debug.Log("x:" + transform.position.x + ", y:" + transform.position.y);
        //Console.WriteLine("update");
        //Debug.Log("update");
		//anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis(axisName)));
		
		
		
		
		//transform.position += transform.up * jumpForce * Time.deltaTime;
		

		if (lastPosition.y <= transform.position.y) {
			// es geht nach oben
			movementUp = true;
		} else {
			movementUp = false;
		}
		lastPosition = transform.position;
		
	}
	
	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Plattform") {
			if (movementUp) {
				//Physics2D.IgnoreCollision(player.collider2D, coll.gameObject.collider2D);
			}
		}
	}

    void OnTriggerStay2D(Collider2D coll)
    {
        Debug.Log("stay");
    }
	
	
	// Update is called once per frame
	void Update () {
		
	}*/
}
