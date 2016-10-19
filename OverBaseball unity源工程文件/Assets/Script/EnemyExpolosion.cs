using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyExpolosion : MonoBehaviour {

	public Transform explosion;
	bool isshot = false;
	public Transform heart;
	public Transform attack;
	public Transform ball;
	public Transform BaseBallBat;

	public BaseBallBatAnim BaseBallBatAnim;

	public KeyCode ShortAttack;

	public int enemyLife;

	bool needCheck = true;

	void Update(){


				
	
		if (isshot) 
		{
			if (enemyLife == 0) {
				Destroy (this.gameObject, 0.5f);
				if(needCheck)//不然每一帧都会调用此一次生成道具
				{
					AppearProperty();
					needCheck = false;
				}
				//随机生成道具

			}
			
		}
	
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.tag == "WeaponBall") {
			isshot = true;
			enemyLife --;
			Transform explosionInstance = Instantiate (explosion,transform.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Transform;

		}

//		if ( collider.gameObject.tag == "BaseBallBat") //近距离攻击 无法解决BaseBallBatAnim.isTarget &&
//		{
//			
//				enemyLife--;
//				Transform explosionInstance = Instantiate (explosion, transform.position, Quaternion.Euler (new Vector3 (0, 0, 0))) as Transform;
//		
//		}
	}

	void AppearProperty(){

		int a = Random.Range (1, 11);// 近距离攻击 生命心 球的概率分别为0.2 0.3 0.5
		if(a > 0 && a < 3)
			{
				Transform attackInstance = Instantiate (attack,transform.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Transform;

			}
		else if(a > 3 && a < 6)
			{
				Transform heartInstance = Instantiate (heart,transform.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Transform;

			}
		else if (a > 6 && a < 11)
			{
				Transform ballInstance = Instantiate (ball,transform.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Transform;

			}

	}
}
