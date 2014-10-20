using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour {
	
	public float speed =1.0f;
	public string axisName = "Horizontal";
	public Animator anim;
	private bool jumping = false;
	private bool jumpUp = false;
	private Vector3 lastPosition = transform.position;
	
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	// Update is called once per frame
	void FixedUpdate () {
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis(axisName)));
		
		
		
		if (Input.GetAxis (axisName) < 0) {
			Vector3 newScale = transform.localScale;
			newScale.y = 1.0f;
			newScale.x = 1.0f;
			transform.localScale = newScale;
		} else if (Input.GetAxis (axisName) > 0) {
			Vector3 newScale = transform.localScale;
			newScale.x = 1.0f;
			transform.localScale = newScale;
		}
		
		transform.position += transform.right *Input.GetAxis(axisName)* speed * Time.deltaTime;
		//transform.position += transform.up * jumpForce * Time.deltaTime;
		
		
		if (jumping && (lastPosition * Vector3.up < transform.position * Vector3.up)) {
			// es geht nach oben
			jumpUp = true;
		} else {
			jumpUp = false;
		}
		lastPosition = transform.position;
		
	}
	
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Plattform") {
			if (jumping && jumpUp) {
				Physics2D.IgnoreCollision(this.collider2D, coll.gameObject.collider2D);
			}
		}
	}
	
	void OnCollisionStay2D(Collision2D coll ) {
		if (coll.gameObject.tag == "Ground" && Input.GetButtonDown("Jump") && !jumping) {
			this.rigidbody2D.AddForce(Vector2.up * 750);
			jumping = true;
		}
	}
	
	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.tag == "Ground") {
			jumping = false;
		} else if (coll.gameObject.tag == "Plattform") {
			// reenable
		}
	}
	
	
	
	// Update is called once per frame
	void Update () {
		
	}
}
