using UnityEngine;
using System.Collections;

public class MainMenuActions : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
	
	}

    public void StartGame()
    {
        Application.LoadLevel("level1");
    }

    public void ExitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
