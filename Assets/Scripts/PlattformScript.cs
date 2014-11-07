using UnityEngine;
using System.Collections;

public class PlattformScript : MonoBehaviour {

    private Collider2D[] colliders = new Collider2D[1];

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            //colliders = this.gameObject.transform.parent.gameObject.GetComponents<Collider2D>();
            colliders = this.gameObject.GetComponents<Collider2D>();
            foreach (Collider2D collider in colliders) {
                if (!collider.isTrigger)
                {
                    collider.enabled = false;
                }
            }
        }
    }


    void OnTriggerExit2D(Collider2D coll)
    {
        foreach (Collider2D collider in colliders)
        {
            if (!collider.isTrigger)
            {
                collider.enabled = true;
            }
        }
    }



}
