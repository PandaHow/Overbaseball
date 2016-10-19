using UnityEngine;
using System.Collections;

public class BallAttack : MonoBehaviour {

	//  敌人冲向的目标
	public Transform target;
	//  敌人移动速度
	public int moveSpeed = 5;
	public float destroyWaitTime = 3;

	void Start () 
	{
		//  通过标签去查找游戏对象
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		//  将它的transform指定给target
		target = go.transform;

	}
	// Update is called once per frame
	void Update () {
	
		transform.position = Vector3.MoveTowards (transform.position, target.position, Time.deltaTime * moveSpeed);

		Destroy (this.gameObject,destroyWaitTime);
	}
}
