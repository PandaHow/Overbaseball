using UnityEngine;
using System.Collections;

public class WeaponBall : MonoBehaviour {

	public Transform explosion;// 当子弹碰到敌人时生成一张爆炸的图 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void OnCollisionEnter2D(Collision2D collision)
	{

		if (collision.gameObject.tag == "Wall") {
			
			Destroy (this.gameObject, 0);//碰到墙子弹自动销毁
		} else if (collision.gameObject.tag == "Enemy1") {
			//enemy1的生命减少 并销毁 


			Destroy (this.gameObject, 0);//碰到墙子弹自动销毁
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		}

	}

	void OnTriggerEnter2D(Collider2D collider)
	{

		if (collider.gameObject.tag == "Wall") {

			Destroy (this.gameObject, 0);//碰到墙子弹自动销毁
		} else if (collider.gameObject.tag == "Enemy1") {
			//enemy1的生命减少 并销毁 


			Destroy (this.gameObject, 0);//碰到墙子弹自动销毁
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		} else if (collider.gameObject.tag == "Enemy2") {

			//enemy2的生命减少 并销毁 
			Destroy (this.gameObject, 0);//碰到墙子弹自动销毁
			Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;

		} 

	}
}
