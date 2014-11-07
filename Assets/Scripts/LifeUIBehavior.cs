using UnityEngine;
using System.Collections;

public class LifeUIBehavior : MonoBehaviour {

    public int lifecount = 1;
    public float hSliderValue = 0.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
    void Update()
    {
        if (lifecount > Globals.LifeCount())
        {
            Destroy(this.gameObject);
        }
    }
}
