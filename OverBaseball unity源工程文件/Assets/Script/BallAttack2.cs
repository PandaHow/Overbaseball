//using UnityEngine;
//using System.Collections;
//
//public class BallAttack2 : MonoBehaviour {
//
//	public float timer = 0;//定义一个时间变量 timer，每帧将此时间减去帧间隔时间 Time.deltaTime，如果小于或者等于零，说明定时器到了，执行相应功能代码，将此定时器重置
//	public float destroyWaitTime = 5.0f;// 球5秒钟没打到人自动销毁
//	public float moveSpeed = 5.0f;//球飞出去的速度
//	//  冲向的目标
//	public Transform target;
//
//	void Start () 
//	{
//		//  通过标签去查找游戏对象
//		GameObject go = GameObject.FindGameObjectWithTag("EnemyTarget");
//		//  将它的transform指定给target
//		target = go.transform;
//
//	}
//
//	void Awake() {
//		timer = Time.time;
//
//	}
//
//	void FixedUpdate () {
//
//
//		transform.position = Vector3.MoveTowards (transform.position, target.position, Time.deltaTime * moveSpeed);
//
//		if (Time.time - timer > destroyWaitTime) {
//
//			Destroy (this.gameObject, destroyWaitTime);
//			timer = 5.0f;
//		}
//
//
//	
//	}
//
//	void randomRun(){
//
//
//		Vector2 velocity = new Vector2 (Random.Range(-19,19),Random.Range(-19,19));
//
//		GetComponent<Rigidbody2D> ().velocity = velocity;
//
//		//给球施加力
////		float x = Random.Range(0,19);
////		Debug.Log (x);
////
////		if(x == 9)
////		transform.position = Vector3.MoveTowards (transform.position, new Vector2(5,8), Time.deltaTime * moveSpeed);
////		else if (x == 8)
////		transform.position = Vector3.MoveTowards (transform.position, new Vector2(6,1), Time.deltaTime * moveSpeed);
////		else if (x == 7)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-3,10), Time.deltaTime * moveSpeed);
////		else if (x == 6)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(10,6), Time.deltaTime * moveSpeed);
////		else if (x == 5)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(6,-6), Time.deltaTime * moveSpeed);
////		else if (x == 4)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-2,8), Time.deltaTime * moveSpeed);
////		else if (x == 3)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(0,7), Time.deltaTime * moveSpeed);
////		else if (x == 2)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-7,0), Time.deltaTime * moveSpeed);
////		else if (x == 1)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-1,6), Time.deltaTime * moveSpeed);
////		else if (x == 0)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(4,4), Time.deltaTime * moveSpeed);
////		else if (x == 10)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(10,12), Time.deltaTime * moveSpeed);
////		else if (x == 11)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-12,-7), Time.deltaTime * moveSpeed);
////		else if (x == 12)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(7,-8), Time.deltaTime * moveSpeed);
////		else if (x == 13)
////		transform.position = Vector3.MoveTowards (transform.position, new Vector2(-9,-9), Time.deltaTime * moveSpeed);
////		else if (x == 14)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-3,9), Time.deltaTime * moveSpeed);
////		else if (x == 15)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-6,10), Time.deltaTime * moveSpeed);
////		else if (x == 16)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(8,-11), Time.deltaTime * moveSpeed);
////		else if (x == 17)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(7,-8), Time.deltaTime * moveSpeed);
////		else if (x == 18)
////			transform.position = Vector3.MoveTowards (transform.position, new Vector2(-9,9), Time.deltaTime * moveSpeed);
////		else
////			transform.
//	}
//}
//
//


using UnityEngine;
using System.Collections;

public class BallAttack2 : MonoBehaviour {

	public float destroyWaitTime = 3;

	void Update () {
		//Destroy (this.gameObject,destroyWaitTime);
	}

	void OnTriggerEnter2D(Collider2D collider)
	{

		if (collider.gameObject.tag == "Wall"   || collider.gameObject.tag == "Enemy1" ) 
			Destroy (this.gameObject,0);

	}

}


