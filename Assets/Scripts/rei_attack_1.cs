using UnityEngine;
using System.Collections;

public class rei_attack_1 : MonoBehaviour {
	public Transform shooterPrefab;
	// Use this for initialization
	void Start () {
		Invoke ("instShooter",0.5f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void instShooter(){
		int select=(int) Mathf.Floor (Random.value * 4);
		float deviation = Random.value * 2f - 1f;
		Transform shooter=Instantiate (shooterPrefab);
		shooter.SetParent (transform);
		switch (select){
		case 0:
			shooter.localPosition=new Vector3(2.5f,deviation,0);
			shooter.GetComponent<Rei_shooter>().direction=-Vector2.right;
			break;
		case 1:
			shooter.localPosition=new Vector3(deviation,2.5f);
			shooter.GetComponent<Rei_shooter>().direction=-Vector2.up;
			break;
		case 2:
			shooter.localPosition=new Vector3(-2.5f,deviation);
			shooter.GetComponent<Rei_shooter>().direction=Vector2.right;
			break;
		case 3:
			shooter.localPosition=new Vector3(deviation,-2.5f);
			shooter.GetComponent<Rei_shooter>().direction=Vector2.up;
			break;
		}
		//Destroy (shooter, 1.5f);
		Invoke ("instShooter",1.3f);
	}
}
