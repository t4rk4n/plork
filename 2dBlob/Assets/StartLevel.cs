using UnityEngine;
using System.Collections;

public class StartLevel : MonoBehaviour {

	public int nextLevel = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Application.loadedLevel("test");
	}

	void nextLevel () {
		Application.loadedLevel("test");
	}
}
