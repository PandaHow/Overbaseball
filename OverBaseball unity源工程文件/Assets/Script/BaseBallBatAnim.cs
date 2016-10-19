using UnityEngine;
using System.Collections;

public class BaseBallBatAnim : MonoBehaviour {


	public KeyCode ShortAttack;//空格键直接挥棒子
//	bool ifBatEnemyCollision = false;
//	bool needCheckin = true;

	public PlayerHP playerHP;

	public Transform explosion;
	public bool isTarget = false;


	void Update(){
		

		if (Input.GetButtonDown ("Fire1")) {


			GetComponent<Animator> ().enabled = true;

			Invoke ("BaseBallBatStop", 0.3f);
		} 

		if (Input.GetKeyDown (ShortAttack)) {
		
			isTarget = true;
			if (playerHP.hp2 > 0) 
			{
				playerHP.hp2 --;
				GetComponent<Animator> ().enabled = true;
				Invoke ("BaseBallBatStop", 0.6f);
			}
		
		}

		else 
			isTarget = false;

	}
		

	void BaseBallBatStop(){
	
		GetComponent<Animator>().enabled = false;

	}






}
