using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PropertyManager : MonoBehaviour {


	public Transform LeftSkill;
	public Transform CenterSkill;
	public Transform RightSkill;

	public Transform heart;
	public Transform ball;
	public Transform attack;

	public Heart heartcs;
	public Attack attackcs;
	public Ball ballcs;
	public PlayerHP playerHP;
	public WeaponBallFirePoint weaponBall;

	public bool isHeartCollision;
	public bool isAttackCollision;
	public bool isBallCollision;

	public KeyCode heart_I;
	public KeyCode ball_O;
	public KeyCode attack_P;
	public KeyCode ShortAttack_Space;

	void Start () {
		
		isHeartCollision = heart.GetComponent<Image> ().enabled;
		isAttackCollision = attack.GetComponent<Image> ().enabled;
		isBallCollision = ball.GetComponent<Image> ().enabled;

	}
	
	// Update is called once per frame
	void Update () {

		if (isHeartCollision) {
			LeftSkill.GetComponent<Image> ().enabled = true;
			heart.GetComponent<Image> ().enabled = true;
		} else {
			LeftSkill.GetComponent<Image> ().enabled = false;
			heart.GetComponent<Image> ().enabled = false;
		}

		if (isBallCollision) {
			CenterSkill.GetComponent<Image> ().enabled = true;
			ball.GetComponent<Image> ().enabled = true;
		} else {
			CenterSkill.GetComponent<Image> ().enabled = false;
			ball.GetComponent<Image> ().enabled = false;
		}

		if (isAttackCollision) {
			RightSkill.GetComponent<Image> ().enabled = true;
			attack.GetComponent<Image> ().enabled = true;
		} else {
			RightSkill.GetComponent<Image> ().enabled = false;
			attack.GetComponent<Image> ().enabled = false;
		}

		//判断按下了哪个道具按键
		KeycodeJudge ();

	
	}

	void KeycodeJudge(){

		if (heart.GetComponent<Image> ().enabled && Input.GetKeyDown (heart_I)) {
			if (playerHP.hp1 < 6) {
				playerHP.hp1 ++ ;
				isHeartCollision = false;

			}

		}
		if ( Input.GetKeyDown (ball_O)) {//ball.GetComponent<Image> ().enabled &&

			weaponBall.BulletShoot ();
			isBallCollision = false;
		}
		if (attack.GetComponent<Image> ().enabled && Input.GetKeyDown (attack_P)) {
			if (playerHP.hp2 < 3) {
				playerHP.hp2++;
				isAttackCollision = false;

			}
		}



	}





}

//LeftSkill.GetComponent<Image> ().enabled = true;
//heart.GetComponent<Image> ().enabled = true;
//
//CenterSkill.GetComponent<Image> ().enabled = true;
//ball.GetComponent<Image> ().enabled = true;
//
//RightSkill.GetComponent<Image> ().enabled = true;
//attack.GetComponent<Image> ().enabled = true;


