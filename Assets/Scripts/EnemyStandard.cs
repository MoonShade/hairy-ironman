using UnityEngine;
using System.Collections;

public class EnemyStandard : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("enemy trigger");
        if (coll.gameObject.tag == "Player")
        {
            Debug.Log("is player");
            coll.gameObject.rigidbody2D.velocity = Vector3.zero;
            coll.gameObject.rigidbody2D.AddForce(Vector2.up * 750 * 0.7F);
        }
    }
}
