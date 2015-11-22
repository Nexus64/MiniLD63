using UnityEngine;
using System.Collections;

public class Mari_bullet_general : MonoBehaviour {
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3(0,0,speed * Time.deltaTime));
	}
}
