using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
	public Transform followObject;
	
	private Vector3 initialOffset;
	
	// Use this for initialization
	void Start ()
	{
		initialOffset = transform.position - followObject.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
	{
		transform.position = followObject.position + initialOffset;
	}
}