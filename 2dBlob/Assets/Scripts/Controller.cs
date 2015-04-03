using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	// Add a thrust force to push an object in its current forward
	// direction (to simulate a rocket motor, say).

	public float thrust;
	public Rigidbody2D rb;
	
	public void  Start() {
		rb = GetComponent<Rigidbody2D>();
	}
	
	public void FixedUpdate () {
		//rb.AddForce(new Vector2(10,0));
	}
}
