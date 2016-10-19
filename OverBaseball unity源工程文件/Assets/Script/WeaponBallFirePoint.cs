using UnityEngine;
using System.Collections;

public class WeaponBallFirePoint : MonoBehaviour {

	public Player player;

	public KeyCode Shoot ;
	public float speed = 5;
	

		//声明发射点
		public Transform firepoint;
		//声明子弹实例
		public Rigidbody2D bullet;


		// Update is called once per frame
		void Update () {




		}

	public void BulletShoot(){
	
		if (Input.GetKeyDown (Shoot)) {
			Rigidbody2D clone;
			clone = (Rigidbody2D)Instantiate (bullet, firepoint.position, Quaternion.Euler (new Vector3 (0, 0, 0)));

			if (player.facingRight) {
				clone.velocity = new Vector2 (speed, 0);
			} 
			else
			{
				clone.velocity = new Vector2 (-speed, 0);

			}


		}
	}


}
