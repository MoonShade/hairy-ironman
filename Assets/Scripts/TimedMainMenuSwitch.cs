using UnityEngine;
using System.Collections;

public class TimedMainMenuSwitch : MonoBehaviour {

    public float timeLeft = 5.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            Application.LoadLevel("MainMenu");
        }
	}
}
