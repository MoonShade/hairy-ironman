using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeSlider : MonoBehaviour {

    public float maxTime = 100F;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        float sliderPos = Time.timeSinceLevelLoad / maxTime;
        this.GetComponent<Slider>().value = sliderPos;

        //Debug.Log(Time.timeSinceLevelLoad.ToString());
        if (Time.timeSinceLevelLoad >= maxTime)
        {
            Application.LoadLevel("TimeUp");
        }
    }
}
