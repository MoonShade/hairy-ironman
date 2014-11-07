using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.gameObject.GetComponent<Text>().text = Globals.GetCoinCount().ToString();
	}
}
