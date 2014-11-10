using UnityEngine;
using System.Collections;

public class EnemyMoving : MonoBehaviour {

    private bool isRight = false;
    public int speed = 4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isRight)
        {
            Vector3 newScale = transform.localScale;
            newScale.x = -1.0f;
            transform.localScale = newScale;
            transform.position += transform.right * 1 * speed * Time.deltaTime;
        }
        else
        {
            Vector3 newScale = transform.localScale;
            newScale.x = 1.0f;
            transform.localScale = newScale;
            transform.position += transform.right * -1 * speed * Time.deltaTime;
        }
	}


    void OnCollisionEnter2D(Collision2D coll)
    {
		if (coll.gameObject.tag == "Side" || coll.gameObject.tag == "Enemy")
        {
            isRight = !isRight;
        }
    }


}
