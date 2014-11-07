using UnityEngine;
using System.Collections;

public class DestroyCoin : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Coin") {
            Destroy(coll.gameObject);
        }
        else if (coll.gameObject.tag == "Player")
        {
            Globals.ReduceLife();
        }
    }
    
}
