using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MouseForce : MonoBehaviour {
	
	public string ForceButton = "Fire1";
	public float Force = 100.0f;
	public Text text;
	public int maxForce;
	public int TimePerForce;
	private int currentTimePerForce = 0;
	private int currentForce;


	bool mouseDown = false;
	Rigidbody2D player;
	// Use this for initialization
	void Start () {
		player = GetComponent<Rigidbody2D>();
	}
	
	void Awake()
	{
		currentForce = maxForce;
	}

	// Update is called once per frame
	void Update ()
	{
		//int force = int.Parse(GuiText.text);
		currentTimePerForce++;
		if (currentTimePerForce >= TimePerForce)
		{
			currentTimePerForce = 0;
			if (currentForce < maxForce)
				currentForce++;
		}

		if (Input.GetMouseButtonDown (0))
			mouseDown = true;
		
		if(Input.GetMouseButtonUp (0))
			mouseDown = false;

		
		if (mouseDown)		{
			if (currentForce <= 0) return;

			currentForce -= 1;
			text.text = currentForce.ToString();

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
		else
			text.text = currentForce.ToString();



	//	force++;
		//GuiText.text = force.ToString();
	}
	
}


