using UnityEngine;
using System.Collections;

public class BossBottom : MonoBehaviour {

	public Transform player;
	public Vector3 offset ;

	public Transform BossBottom2;
	public Transform BossLand1;
	public Transform BossLand2;
	public Transform BossLand3;
	public Transform BossLandDust;
	public Transform Boss;
	public Transform BossAnim1;
	public Transform BossAnim2;
	public bool BossIsLand = false;

	void Start () {

		player = GameObject.Find ("Player").GetComponent<Transform> ();
		offset = player.position - this.transform.position;

		Invoke ("BottomChange", 3.0f);
		Invoke ("Boss1Land", 5.0f);
		Invoke ("Boss2Land", 5.7f);
		Invoke ("Boss3Land", 6.4f);
		Invoke ("BossAppear", 7.1f);
		Invoke ("BossNormalRun", 8.8f);

	}


	void Update(){

		this.transform.position = player.position - offset;

	

}


	void BottomChange(){
	
		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = true;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = false;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = false;
		Boss.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void Boss1Land(){
		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = true;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = false;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = true;
		Boss.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void Boss2Land(){
		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = true;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = false;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = true;
		Boss.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void Boss3Land(){
		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = true;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = true;
		Boss.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void BossAppear(){

		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = false;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = true;
		Boss.GetComponent<SpriteRenderer> ().enabled = true;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = false;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = false;
	}

	void BossNormalRun(){

		GetComponent<SpriteRenderer> ().enabled = false;
		BossBottom2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand1.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand2.GetComponent<SpriteRenderer> ().enabled = false;
		BossLand3.GetComponent<SpriteRenderer> ().enabled = false;
		BossLandDust.GetComponent<SpriteRenderer> ().enabled = false;
		Boss.GetComponent<SpriteRenderer> ().enabled = true;
		BossAnim1.GetComponent<SpriteRenderer> ().enabled = true;
		BossAnim2.GetComponent<SpriteRenderer> ().enabled = true;

		BossIsLand = true;
	}
}


//InvokeRepeating("TeleportationDisappear", 5.0f,5); 

//Invoke ("RegainMoveForce", 1.0f);