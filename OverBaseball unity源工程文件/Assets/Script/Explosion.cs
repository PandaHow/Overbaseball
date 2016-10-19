using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

	// Use this for initialization

	public float time = 0.5f;
	// Update is called once per frame
	void Update () {
	
		Destroy (this.gameObject,time);
	}
}
