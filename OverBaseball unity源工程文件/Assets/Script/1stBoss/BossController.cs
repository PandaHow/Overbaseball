using UnityEngine;
using System.Collections;

public class BossController : MonoBehaviour {

	public BossBottom BossBottom;

	public Transform bossbottom;
	public Vector3 offset ;
	public Transform explosion;

	void Start(){
	
		bossbottom = GameObject.Find ("BossBottom").GetComponent<Transform> ();
		offset = bossbottom.position - this.transform.position;


	}

	void Update()
	{
		
		if (BossBottom.BossIsLand) {
		
			//停止跟随
			GetComponent<Rigidbody2D>().velocity = new Vector2 (0,0);

			Invoke("Shoot", 1.0f);  

		} else {
		
			this.transform.position = bossbottom.position - offset;

		}
			

	}

	void shoot(){



	}

	void OnTriggerEnter2D(Collider2D collider)
	{
	if (collider.gameObject.tag == "WeaponBall")
		{//player 减血
			//playerHP.hp1 --;
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		}
	}



}
