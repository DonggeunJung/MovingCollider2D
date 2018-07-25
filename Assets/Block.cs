using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {
	public float minHeight;
	public float maxHeight;
	public GameObject pivot;

	// Use this for initialization
	void Start () {
		// Change gap height when start
		ChangeHeight();
	}

	void ChangeHeight() {
		// Make particular height and apply
		float height = Random.Range(minHeight, maxHeight);
		pivot.transform.localPosition = new Vector3 (0.0f, height, 0.0f);
	}

	void onScrollEnd() {
		ChangeHeight ();
	}

}
