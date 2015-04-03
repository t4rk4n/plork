using UnityEngine;
using System.Collections;

public class GravityNode : MonoBehaviour {

	public GameObject player;
	Rigidbody2D playerRigid;
	public float strength;
	public float strength2;

	// Use this for initialization
	void Start () {
		playerRigid = player.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector2 vector = this.gameObject.transform.position - player.gameObject.transform.position;

		Vector2 dir = vector.normalized;
		float dist = Mathf.Max(0.5f, vector.magnitude);
		print (dist);
		float force = strength / (dist * dist);

		float force2 = strength2 / (dist * dist * dist * dist);
		playerRigid.AddForce (dir * (force + force2) );
	}
}
