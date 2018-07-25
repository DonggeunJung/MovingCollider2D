using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
		if (Input.GetAxis("Vertical") > 0) {
			pos.y += 0.1f;
			transform.position = pos;
		}
		else if (Input.GetAxis("Vertical") < 0) {
			pos.y -= 0.1f;
			transform.position = pos;
		}
	}

	void OnCollisionEnter2D (Collision2D collision) {
		print ("OnCollisionEnter");
	}
}
