using UnityEngine;
using System.Collections;

public class PlayerJumpController : MonoBehaviour {

    private bool jumping = false;
    public string axisName = "Horizontal";
    public float speed = 1.0f;
    private Vector3 lastPosition = new Vector3();
    private bool movementUp = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis(axisName) < 0)
        {
            Vector3 newScale = transform.localScale;
            newScale.y = 1.0f;
            newScale.x = 1.0f;
            transform.localScale = newScale;
        }
        else if (Input.GetAxis(axisName) > 0)
        {
            Vector3 newScale = transform.localScale;
            newScale.x = 1.0f;
            transform.localScale = newScale;
        }

        transform.position += transform.right * Input.GetAxis(axisName) * speed * Time.deltaTime;


        if (lastPosition.y < transform.position.y)
        {
            // es geht nach oben
            movementUp = true;
        }
        else
        {
            movementUp = false;
        }
        lastPosition = transform.position;
	}




    void OnCollisionStay2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground" && Input.GetButton("Jump") && !jumping && !movementUp)
        {
            this.rigidbody2D.AddForce(Vector2.up * 750);
            jumping = true;
        }
    }


    void OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ground")
        {
            jumping = false;
        }
        else if (coll.gameObject.tag == "Plattform")
        {
            // reenable
        }
    }



}
