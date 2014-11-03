using UnityEngine;
using System.Collections;

public class LifeUIBehavior : MonoBehaviour {

    public int lifecount = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (lifecount > Globals.Lifes)
        {
            Destroy(this.gameObject);
        }
	}
}
