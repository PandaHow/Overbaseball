using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Ball : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.gameObject.tag == "Player") {
			Destroy (this.gameObject,1.0f);


		}
	}


}
