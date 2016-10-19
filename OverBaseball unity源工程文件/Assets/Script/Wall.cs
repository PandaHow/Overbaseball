using UnityEngine;
using System.Collections;

public class Wall : MonoBehaviour {

	public Player playerScript;
	public Transform player;

	void OnTriggerEnter2D(Collider2D collider)
	{
		//Vector3 pos = new Vector3(player.position.x-1,player.position.y,0);


		if (collider.gameObject.tag == "Player")
		{
			playerScript.moveForce = 0;
			//player.GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
			//playerScript.facingRight = !playerScript.facingRight;
			Invoke ("RegainMoveForce", 1.0f);

		}
	}

	void RegainMoveForce(){
		playerScript.moveForce = 1000f;
	}



}
