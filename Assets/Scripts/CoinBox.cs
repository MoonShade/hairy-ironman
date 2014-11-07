using UnityEngine;
using System.Collections;

public class CoinBox : MonoBehaviour {

    public GameObject coin;
    public bool isCoin = true;
    public float force = 500F;

    private bool jumped = false;

	// Use this for initialization
	void Start () {
        coin.GetComponent<Rigidbody2D>().active = false;
        coin.active = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player" && !jumped)
        {
            // coin geht raus
            coin.GetComponent<Rigidbody2D>().active = true;
            coin.GetComponent<Rigidbody2D>().AddForce(Vector2.up * force);
            coin.active = true;
            jumped = true;
            if (isCoin)
            {
                Globals.AddCoin();
            }
            //coin.transform.position = new Vector3(0,0,0);

        }


    }

}
