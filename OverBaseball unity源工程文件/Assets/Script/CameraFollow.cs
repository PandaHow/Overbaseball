using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour 
{
	public float xMargin = 1f;		// 在摄像机开始跟随时主角可以移动的范围
	public float yMargin = 1f;		
	public float xSmooth = 8f;		// 摄像机跟随主角运动的平滑程度 用于lerp函数中
	public float ySmooth = 8f;		
	public Vector2 maxXAndY;		// x y 坐标轴的临界值 
	public Vector2 minXAndY;		


	private Transform player;		// 主角的位置作参考


	void Awake ()
	{
		
		player = GameObject.FindGameObjectWithTag("Player").transform;
	}


	bool CheckXMargin()
	{
		//在x轴上两者的距离绝对值如果比xmargin大 为真
		return Mathf.Abs(transform.position.x - player.position.x) > xMargin;
	}


	bool CheckYMargin()
	{
		return Mathf.Abs(transform.position.y - player.position.y) > yMargin;
	}


	void FixedUpdate ()
	{
		TrackPlayer(); //跟随函数
	}


	void TrackPlayer ()
	{
		// 相机target x和y坐标是当前的x和y坐标。
		float targetX = transform.position.x;
		float targetY = transform.position.y;

		// 如果x在不跟随的范围内
		if(CheckXMargin())
			//target x 坐标应该在相机当前x坐标和主角当前的x坐标之间移动
			targetX = Mathf.Lerp(transform.position.x, player.position.x, xSmooth * Time.deltaTime);

		if(CheckYMargin())
			targetY = Mathf.Lerp(transform.position.y, player.position.y, ySmooth * Time.deltaTime);

		//target x和y坐标不应该超过极值
		targetX = Mathf.Clamp(targetX, minXAndY.x, maxXAndY.x);
		targetY = Mathf.Clamp(targetY, minXAndY.y, maxXAndY.y);

		// 相机z坐标不变
		transform.position = new Vector3(targetX, targetY, transform.position.z);
	}
}
