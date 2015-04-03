using UnityEngine;
using System.Collections;

public class MouseForce : MonoBehaviour {
	
	public string ForceButton = "Fire1";
	public float Force = 100.0f;
	
	bool mouseDown = false;
	Rigidbody2D player;
	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		
		if (Input.GetMouseButtonDown (0))
			mouseDown = true;
		
		if(Input.GetMouseButtonUp (0))
			mouseDown = false;
		
		if (mouseDown)		{
			//var mouseClick = Input.mousePosition;
			
			//var xForce : float = 0;
			//var yForce : float = 0;
			//var zForce : float = 0;
			//mus - pos
			Vector3 point = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			var direction = (point - player.transform.position).normalized;
			player.AddForce (direction*-1 * Force);
			
			//GetComponent<Rigidbody2D> ().a AddForce (Vector3. (mouseClick.x,mouseClick.y,mouseClick.z) * 300);
		}
		
	}
	
}


