using UnityEngine;
using System.Collections;

public class BossBulletFollow : MonoBehaviour {

	public Transform player;
	public float moveSpeed = 5;

	void Start () 
	{
		//  通过标签去查找游戏对象
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		//  将它的transform指定给target
		player = go.transform;

	}

	void Update()
	{
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (0,0);
		Vector3 Pos = Camera.main.WorldToScreenPoint (player.position);
		transform.position = Vector3.MoveTowards (transform.position, player.position, Time.deltaTime * moveSpeed);

		Destroy (this.gameObject,6.0f);

	}
}
