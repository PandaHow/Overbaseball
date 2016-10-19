using UnityEngine;
using System.Collections;

public class FIreball : MonoBehaviour {

	public Transform explosion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.gameObject.tag == "Player") 
		{
			Destroy (this.gameObject,0.5f);
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		}
	}
}
