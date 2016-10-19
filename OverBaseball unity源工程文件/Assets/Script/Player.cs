using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	[HideInInspector]
	public bool facingRight = true;
	public KeyCode teleportation;

	public Transform Teleportation1;
	public Transform Teleportation2;
	public Transform Teleportation3;
	public Transform Teleportation4;

	public Transform prefab1;
	public Transform prefab2;
	public Transform prefab3;
	public Transform prefab4;
	public float moveForce = 200f;
	public float maxSpeed =5f;
	public float teleportationMoveSpeed = 100;
	public PropertyManager PropertyManager;

	public Transform explosion;// 当主角碰到子弹时生成一张爆炸的图 

//	void OnDrawGizmosSelected(){
//		Gizmos.color = Color.blue;
//		Vector3 posss = new Vector3 (5, 5, 0);
//		Gizmos.DrawLine (transform.position, posss);
//		Debug.Log ("sfdd");
//	}	


	void FixedUpdate(){

		//Debug.DrawRay(contact.point, contact.normal, Color.green, 2);

	

		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		if (h > 0 && !facingRight) {
			Flip ();
		}
		else if(h < 0 && facingRight)
		{
			Flip ();
		}

		//行进功能设置

		if (h * GetComponent<Rigidbody2D> ().velocity.x < maxSpeed) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.right * h *moveForce);//我也不懂这一段什么意思 背下来就好了
		}

		//限速功能
		if (Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.x) > maxSpeed) {
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		}

		if (v * GetComponent<Rigidbody2D> ().velocity.y < maxSpeed) {
			GetComponent<Rigidbody2D> ().AddForce (Vector2.up * v *moveForce);//我也不懂这一段什么意思 背下来就好了
		}

		//限速功能
		if (Mathf.Abs (GetComponent<Rigidbody2D> ().velocity.y) > maxSpeed) {
			GetComponent<Rigidbody2D>().velocity = new Vector2( GetComponent<Rigidbody2D>().velocity.x , Mathf.Sign(GetComponent<Rigidbody2D>().velocity.y) * maxSpeed);

		}

		if (Input.GetKeyDown (teleportation)) {

				Teleportation ();
		
		}

	}

	//转身功能

		void Flip()
		{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
		
	//瞬间移动功能


		void Teleportation(){
		
		Teleportation1.GetComponent<SpriteRenderer> ().enabled = true;
		Teleportation2.GetComponent<SpriteRenderer> ().enabled = true;
		Teleportation3.GetComponent<SpriteRenderer> ().enabled = true;
		Teleportation4.GetComponent<SpriteRenderer> ().enabled = true;

		if (facingRight) {
			Vector3 tarPosition = new Vector3 (transform.position.x + 16, transform.position.y, 0);
			transform.position = Vector3.MoveTowards (transform.position, tarPosition, Time.deltaTime * teleportationMoveSpeed);

		} else {

			Vector3 tarPosition2 = new Vector3 (transform.position.x - 16, transform.position.y, 0);
			transform.position = Vector3.MoveTowards (transform.position, tarPosition2, Time.deltaTime * teleportationMoveSpeed);

		}

		InvokeRepeating("TeleportationDisappear", 0.5f,5); //0.5秒后开始调用『』内函数 每隔5s一次
			
	}



	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.gameObject.tag == "Bullet") {
			Destroy(collider.gameObject);
			Transform explosionInstance = Instantiate (explosion,transform.position, Quaternion.Euler(new Vector3 (0, 0, 0))) as Transform;
		}

		if (collider.gameObject.tag == "Heart") 
		{

			PropertyManager.isHeartCollision = true;
		}

		if(collider.gameObject.tag == "Ball")
		{

			PropertyManager.isBallCollision = true;
		}

		if(collider.gameObject.tag == "Attack")
		{
			

			PropertyManager.isAttackCollision = true;
		}
	}

	void TeleportationDisappear(){
		Teleportation1.GetComponent<SpriteRenderer> ().enabled = false;
		Teleportation2.GetComponent<SpriteRenderer> ().enabled = false;
		Teleportation3.GetComponent<SpriteRenderer> ().enabled = false;
		Teleportation4.GetComponent<SpriteRenderer> ().enabled = false;
	}




}



//if (facingRight) {
//	Vector3 tarPosition = new Vector3 (transform.position.x+16,transform.position.y,0);
//	Instantiate(prefab1, new Vector3(transform.position.x,transform.position.y, 0), Quaternion.identity);
//	Instantiate(prefab2, new Vector3(transform.position.x-1,transform.position.y, 0), Quaternion.identity);
//	Instantiate(prefab3, new Vector3(transform.position.x-3,transform.position.y, 0), Quaternion.identity) ;
//	Instantiate(prefab4, new Vector3(transform.position.x-5,transform.position.y, 0), Quaternion.identity);
//	transform.position = Vector3.MoveTowards(transform.position,tarPosition,Time.deltaTime * teleportationMoveSpeed);//移动到指定位置
//
//}
//else
//{
//	Vector3 theScale1 = prefab1.transform.localScale;
//	theScale1.x *= -1;
//	prefab1.transform.localScale = theScale1;
//
//	Vector3 theScale2 = prefab2.transform.localScale;
//	theScale2.x *= -1;
//	prefab2.transform.localScale = theScale2;
//
//	Vector3 theScale3 = prefab3.transform.localScale;
//	theScale3.x *= -1;
//	prefab3.transform.localScale = theScale3;
//
//	Vector3 theScale4 = prefab4.transform.localScale;
//	theScale4.x *= -1;
//	prefab4.transform.localScale = theScale4;
//
//	Vector3 tarPosition = new Vector3 (transform.position.x-16,transform.position.y,0);
//	Instantiate(prefab1, new Vector3(transform.position.x,transform.position.y, 0), Quaternion.identity);
//	Instantiate(prefab2, new Vector3(transform.position.x-1,transform.position.y, 0), Quaternion.identity);
//	Instantiate(prefab3, new Vector3(transform.position.x-3,transform.position.y, 0), Quaternion.identity) ;
//	Instantiate(prefab4, new Vector3(transform.position.x-5,transform.position.y, 0), Quaternion.identity);
//	transform.position = Vector3.MoveTowards(transform.position,tarPosition,Time.deltaTime * teleportationMoveSpeed);//移动到指定位置
//
//}
