using UnityEngine;
using System.Collections;

public class BossBulletExplosion : MonoBehaviour {

	public Transform explosion;
	public PlayerHP playerHP;
	
	// Update is called once per frame
	void Update () {

		float random = Random.Range (0.3f,1.0f);

		Invoke ("StopAnim", random );
	
	}

	void StopAnim()

	{
		GetComponent<Animator> ().enabled = false;
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Wall") 
			Destroy (this.gameObject,0);

		else if (collider.gameObject.tag == "Player") 
		{//player 减血
			//playerHP.hp1 --;
			Destroy (this.gameObject,0);
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		}
		

	}
}
