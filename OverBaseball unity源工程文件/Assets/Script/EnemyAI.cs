using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour 
{
	//  敌人冲向的目标
	public Transform target;
	//  敌人移动速度
	public int moveSpeed = 5;

	//  敌人和玩家之间的最大/小 距离
	public int maxDistance = 4;
	public int minDistance = 2;

	public float life1;


	void Start () 
	{
		//  通过标签去查找游戏对象
		GameObject go = GameObject.FindGameObjectWithTag("Player");
		//  将它的transform指定给target
		target = go.transform;

	}

	void Update () 
	{
		//  在敌人和玩家 鼠标和玩家 之间画一条线
		Debug.DrawLine(target.position,transform.position,Color.red);
		DrawLineBetweenMouseAndPlayer ();
		//Debug.DrawLine(Camera.main.WorldToScreenPoint(target.position),Input.mousePosition,Color.blue);
			//  判断敌人和玩家之间的距离是否大于最大距离
		if (Vector3.Distance (target.position, transform.position) > minDistance && Vector3.Distance (target.position, transform.position)<maxDistance) {
			//  移向目标
			transform.position = Vector3.MoveTowards (transform.position, target.position, Time.deltaTime * moveSpeed); 

			Aim ();

		} 

		else if(Vector3.Distance (target.position, transform.position) > maxDistance){
			//离得太远 什么也不做
		}

		else {

			//靠近的时候 只瞄准目标 不移动

			Aim ();

		}
	}

	void Aim(){
	
		//申请一个变量存储角度值。

		float angle;

		//计算角度

		angle =Mathf.Rad2Deg*Mathf.Atan ((transform.position.y - target.position.y) / (transform.position.x - target.position.x));

		//判断角度所在象限，并进行修正。

		if (transform.position.x - target.position.x < 0)

			angle=angle-90;

		else 

			angle=angle+90;

		//设置物体的自身欧拉角，是物体绕自身坐标系在Z轴，旋转Z度。

		transform.localEulerAngles=new Vector3(0,0,angle);
	
	}

	void DrawLineBetweenMouseAndPlayer(){


	}





}
	