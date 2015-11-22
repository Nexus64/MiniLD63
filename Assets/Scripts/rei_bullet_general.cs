using UnityEngine;
using System.Collections;

public class rei_bullet_general : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = 
			new Vector3 (0, 0, Vector2.Angle(GetComponent<Rigidbody2D> ().velocity, Vector2.right)-90);
	}
}
