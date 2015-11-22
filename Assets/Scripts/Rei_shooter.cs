using UnityEngine;
using System.Collections;

public class Rei_shooter : MonoBehaviour {
	public Transform bulletPrefab;
	public Vector2 direction;
	public float speed;
	// Use this for initialization
	void Start () {
		Invoke("shoot",0.3f);
		Destroy (gameObject, 1.5f);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void shoot(){

		Transform bullet1=Instantiate (bulletPrefab);
		Transform bullet2=Instantiate (bulletPrefab);
		if (direction == Vector2.up || direction == -Vector2.up) {
			bullet1.position = (Vector2)transform.position + new Vector2 (-0.25f, 0f);
			bullet2.position = (Vector2)transform.position + new Vector2 (0.25f, 0f);
		} else {
			bullet1.position = (Vector2)transform.position + new Vector2 (0f, -0.25f);
			bullet2.position = (Vector2)transform.position + new Vector2 (0f, 0.25f);
		}
		bullet1.GetComponent<Rigidbody2D> ().velocity = direction * speed;
		bullet2.GetComponent<Rigidbody2D> ().velocity = direction * speed;
		Invoke("shoot",0.3f);
	}
}
