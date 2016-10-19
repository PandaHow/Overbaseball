using UnityEngine;
using System.Collections;

public class FlameBall2 : MonoBehaviour {

	//声明发射点
	public Transform firepoint;
	//声明子弹实例
	public Rigidbody2D bullet;
	//声明子弹间隔
	public float fireRate = 2f; 


	// Update is called once per frame
	void Update () {

		fireRate -= Time.deltaTime;
		if (fireRate <= 0) {
			//更新间隔时间
			//nextFire = Time.time + fireRate;
			//通过射线获得目标点

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			//Ray ray = Camera.main.ScreenPointToRay(Enemy2_Ball_Target.transform.position);
			Vector3 target = ray.GetPoint (10);
			firepoint.LookAt (target);
			//实例化子弹
			Rigidbody2D clone;
			clone = (Rigidbody2D)Instantiate (bullet, firepoint.position, Quaternion.Euler (new Vector3 (0, 0, 0)));
			//初始化子弹的方向速度
			//clone.velocity = target-firepoint.position;
			float x = Random.Range (-10, 10);
			float y = Random.Range (-10, 10);
			clone.velocity = new Vector3 (x, y, 0);

			fireRate = 2;
		}


	}

	void OnTriggerEnter2D(Collider2D collider)
	{

		if (collider.gameObject.tag == "Player") 
			Destroy (collider.gameObject);

	}

}