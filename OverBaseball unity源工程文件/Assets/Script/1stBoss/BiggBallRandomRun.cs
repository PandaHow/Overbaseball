using UnityEngine;
using System.Collections;

public class BiggBallRandomRun : MonoBehaviour {

	public Transform explosion;
	public float stopTime;
	public float moveTime;
	float vel_x, vel_y, vel_z;//速度
	/// <summary>
	/// 最大、最小飞行界限
	/// </summary>
	public float moveSpeed = 10;
	float maxPos_x = 8;
	float maxPos_y = 8;
	float minPos_x = -8;
	float minPos_y = -8;
	int curr_frame;
	int total_frame;
	float timeCounter1;
	float timeCounter2;
	// int max_Flys = 128;
	// Use this for initialization
	void Start()
	{
		Change();

	}

	// Update is called once per frame
	void Update()
	{
		timeCounter1 += Time.deltaTime;
		if (timeCounter1 < moveTime)
		{
			//transform.Translate(vel_x, vel_y, 0, Space.Self);
			Vector3 targetPosition = new Vector3(vel_x,vel_y,0);
			transform.position = Vector3.MoveTowards(transform.position,targetPosition,Time.deltaTime * moveSpeed);//移动到指定位置
		}
		else
		{
			timeCounter2 += Time.deltaTime;
			if (timeCounter2 > stopTime)
			{
				Change();
				timeCounter1 = 0;
				timeCounter2 = 0;
			}
		}
		Check();
	}
	void Change()
	{
		stopTime = Random.Range(1, 2);
		moveTime = Random.Range(1, 2);
		vel_x = Random.Range(-8, 8);
		vel_y = Random.Range(-8, 8);
	}
	void Check()
	{
		//如果到达预设的界限位置值，调换速度方向并让它当前的坐标位置等于这个临界边的位置值
		if (transform.localPosition.x > maxPos_x)
		{
			vel_x = -vel_x;
			transform.localPosition = new Vector3(maxPos_x, transform.localPosition.y, 0);
		}
		if (transform.localPosition.x < minPos_x)
		{
			vel_x = -vel_x;
			transform.localPosition = new Vector3(minPos_x, transform.localPosition.y, 0);
		}
		if (transform.localPosition.y > maxPos_y)
		{
			vel_y = -vel_y;
			transform.localPosition = new Vector3(transform.localPosition.x, maxPos_y, 0);
		}
		if (transform.localPosition.y < minPos_y)
		{
			vel_y = -vel_y;
			transform.localPosition = new Vector3(transform.localPosition.x, minPos_y, 0);
		}
	}

}
