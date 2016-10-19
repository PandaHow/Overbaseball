using UnityEngine;
using System.Collections;

public class BallRebound : MonoBehaviour
{
	public float reboundSpeed = 0.5f;
	public Transform BaseBallBat;

	public bool canRebound = false;
	public bool rebound;

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "Circle")
	    canRebound = true;
		else
		Debug.Log ("没碰撞到circle");

	}


	void Update(){

		if (canRebound) 
		{
			if (Input.GetButtonDown("Fire1"))
			{
				//Debug.Log ("这里应该写反弹函数");

				//更改子弹本身的bullet tag 改成 weaponball tag

				GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);//1stboss加上去的
				gameObject.tag = "WeaponBall";


				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
				Vector3 target = ray.GetPoint(10);
				Vector3 go = Camera.main.ScreenToWorldPoint (transform.position);
				target.z = go.z;

				transform.LookAt (target);
				GetComponent<Rigidbody2D> ().velocity = (target - transform.position)*reboundSpeed;
//

//				Vector3 e = Input.mousePosition;
//				Vector3 ballPos = Camera.main.WorldToScreenPoint (transform.position);
//						
//				e.z = ballPos.z;
//				Vector3 mousePos = Camera.main.ScreenToWorldPoint(e);
//										
//						
//				transform.LookAt (mousePos);
//				transform.Translate(Vector3.forward * reboundSpeed * Time.deltaTime); 

			}

		}
	
	}




}



//if (collider.gameObject.tag == "Circle")
//
//{
//	if (Input.GetButtonDown ("Fire1")) 
//
//	{
//		//反弹
//
//		//				Vector3 e = Input.mousePosition;
//		//				Vector3 ballPos = Camera.main.WorldToScreenPoint (transform.position);
//		//
//		//				e.z = ballPos.z;
//		//				Vector3 mousePos = Camera.main.ScreenToWorldPoint(e);
//		//				
//		//
//		//				transform.LookAt (mousePos);
//		//				transform.Translate(Vector3.forward * reboundSpeed * Time.deltaTime); 
//
//		Destroy (this.gameObject, 1.0f);
//		Debug.Log ("sdsdfsd");
//
//
//	}
//
//}
//	