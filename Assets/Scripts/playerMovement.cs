using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

	public float speed;
	public float s =0;
	private Rigidbody2D rigidBody2D;
	// Use this for initialization
	void Start () {
		rigidBody2D = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.RightArrow)){
			rigidBody2D.AddForce(Vector2.right*speed);
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			rigidBody2D.AddForce(-Vector2.right*speed);

		}

		if (Input.GetKey(KeyCode.UpArrow)){
			rigidBody2D.AddForce(Vector2.up*speed);
		}

		if (Input.GetKey(KeyCode.DownArrow)){
			rigidBody2D.AddForce(-Vector2.up*speed);
		}
		s = rigidBody2D.velocity.magnitude;
	}
}
