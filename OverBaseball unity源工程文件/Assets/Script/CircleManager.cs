using UnityEngine;
using System.Collections;

public class CircleManager : MonoBehaviour {

	public Transform circle1;
	public Transform circle2;
	public Transform circle3;

	void FixedUpdate()
	{
	
		Vector3 mousePos = Input.mousePosition;
		//Debug.Log (mousePos);

		if (mousePos.x < Screen.width / 2 && mousePos.y > Screen.height / 2)
		{
			//Debug.Log ("left");
			circle1.GetComponent<SpriteRenderer> ().enabled = false;
			circle2.GetComponent<SpriteRenderer> ().enabled = true;
			circle3.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else if (mousePos.x > Screen.width / 2 && mousePos.y > Screen.height / 2)
		{
			circle1.GetComponent<SpriteRenderer> ().enabled = true;
			circle2.GetComponent<SpriteRenderer> ().enabled = false;
			circle3.GetComponent<SpriteRenderer> ().enabled = false;
		}
		else if (mousePos.y < Screen.height / 2)
		
		{
			circle1.GetComponent<SpriteRenderer> ().enabled = false;
			circle2.GetComponent<SpriteRenderer> ().enabled = false;
			circle3.GetComponent<SpriteRenderer> ().enabled = true;
		}



	}




	void fun(){
					Vector3 theScale = transform.localScale;
					theScale.x *= -1;
					transform.localScale = theScale;
	
	}

	void function ()
	{
		//Debug.Log (this.transform.position);
		Vector3 pos = Camera.main.ScreenToWorldPoint (this.transform.position);
		//Debug.Log (pos);
		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//Debug.Log (mousePos);

		if (mousePos.y > pos.y) {
			if (mousePos.x < pos.x)
			{
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				Debug.Log ("小鱼");
			} 
			else
				Debug.Log ("吃饭");

		} 

		else 
			Debug.Log ("睡觉");

	}

	}





