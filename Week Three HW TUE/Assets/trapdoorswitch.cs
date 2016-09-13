using UnityEngine;
using System.Collections;

public class trapdoorswitch : MonoBehaviour {
	float rotationspeed = 5;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//if I hit a specific key, open the trap door
		if (Input.GetKey( KeyCode.W )){
			print("open trapdoor!");
			// rotatationspeed z to -90degree
			transform.Rotate(Vector3.forward * rotationspeed);
		}
	}
}