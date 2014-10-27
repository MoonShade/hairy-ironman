using UnityEngine;
using System.Collections;

public class CameraFollowPlayer : MonoBehaviour {

    public GameObject player;
    private float xVelocity = 0.0F;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.position = new Vector3(Mathf.SmoothDamp(this.transform.position.x, player.transform.position.x, ref xVelocity, 0.1F), player.transform.position.y, player.transform.position.z);
	}
}
