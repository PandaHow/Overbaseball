using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour {

	public float hp1 = 6;//UI界面最下方的主角生命值
	public float hp2 = 3;//上面的近距离攻击次数


	public Transform PlayerHP1_6;
	public Transform PlayerHP1_5;
	public Transform PlayerHP1_4;
	public Transform PlayerHP1_3;
	public Transform PlayerHP1_2;
	public Transform PlayerHP1_1;

	public Transform PlayerHP2_3;
	public Transform PlayerHP2_2;
	public Transform PlayerHP2_1;


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Hp1Judge ();
		Hp2Judge ();


	}


	void OnTriggerEnter2D(Collider2D collider) {

		if (collider.gameObject.tag == "Bullet") {
			hp1--;
		}
	}

	void Hp1Judge (){
	
		if (hp1 == 6) {

			PlayerHP1_6.GetComponent<Image> ().enabled = true;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp1 == 5) {

			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = true;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp1 == 4) {

			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = true;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp1 == 3) {

			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = true;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp1 == 2) {

			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = true;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

		} else if (hp1 == 1) {

			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = true;

		} 

		else
		{
			PlayerHP1_6.GetComponent<Image> ().enabled = false;
			PlayerHP1_5.GetComponent<Image> ().enabled = false;
			PlayerHP1_4.GetComponent<Image> ().enabled = false;
			PlayerHP1_3.GetComponent<Image> ().enabled = false;
			PlayerHP1_2.GetComponent<Image> ().enabled = false;
			PlayerHP1_1.GetComponent<Image> ().enabled = false;

			//生命值为o 死亡

		}
	}

	void Hp2Judge(){
	
		if (hp2 == 3) {

			PlayerHP2_3.GetComponent<Image> ().enabled = true;
			PlayerHP2_2.GetComponent<Image> ().enabled = false;
			PlayerHP2_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp2 == 2) {

			PlayerHP2_3.GetComponent<Image> ().enabled = false;
			PlayerHP2_2.GetComponent<Image> ().enabled = true;
			PlayerHP2_1.GetComponent<Image> ().enabled = false;

		}
		else if (hp2 == 1) {

			PlayerHP2_3.GetComponent<Image> ().enabled = false;
			PlayerHP2_2.GetComponent<Image> ().enabled = false;
			PlayerHP2_1.GetComponent<Image> ().enabled = true;

		}
		else if (hp2 == 0) {

			PlayerHP2_3.GetComponent<Image> ().enabled = false;
			PlayerHP2_2.GetComponent<Image> ().enabled = false;
			PlayerHP2_1.GetComponent<Image> ().enabled = false;

		}
			
	}






}
