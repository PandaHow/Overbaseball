using UnityEngine;
using System.Collections;

public class CircleRotate : MonoBehaviour {

	public Transform player;

	Vector3 e = Input.mousePosition;//鼠标的位置  

	void FixedUpdate(){
		if (e.y > Screen.height/2) {
			if (e.x < Screen.width/2) {
				Vector3 theScale = transform.localScale;
				theScale.x *= -1;
				transform.localScale = theScale;
				Debug.Log ("小鱼");
			} else
				Debug.Log ("吃饭");

		} else {
			Debug.Log ("睡觉");
		}
	}
}
