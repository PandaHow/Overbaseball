using UnityEngine;
using System.Collections;

public class FlameBall1 : MonoBehaviour {

	//声明发射点
	public Transform firePoint;

	public Rigidbody2D flame;
	public Transform player;
	public Transform enemy1;
	public float speed = 50f;
	public float timer = 2.0f;//定义一个时间变量 timer，每帧将此时间减去帧间隔时间 Time.deltaTime，如果小于或者等于零，说明定时器到了，执行相应功能代码，将此定时器重置
	public int maxDistance = 5;
	public int minDistance = 4;

	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {

			if (Vector3.Distance (player.position, enemy1.position)<maxDistance) 
			{
				Vector3 Pos = Camera.main.WorldToScreenPoint (firePoint.position);
				Vector2 playerPos = player.position;//目标坐标
				Rigidbody2D flameInstance = Instantiate (flame,firePoint.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Rigidbody2D;


			} 

//			
			timer = 1.0f;
		}


	}

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.gameObject.tag == "Player") {
			Destroy (collider.gameObject);

		}
	}
}