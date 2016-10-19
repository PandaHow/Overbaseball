using UnityEngine;

using System.Collections;
public class Mouse : MonoBehaviour {
	public Texture2D mouseTexture;  //自己想要的鼠标图片

	// Use this for initialization

	void Start () {
		Cursor.visible = false;

	}


	// Update is called once per frame

	void Update () {


	}
	void OnGUI()

	{

		Vector3 mousePos = Input.mousePosition;
		GUI.DrawTexture(new Rect(mousePos.x,Screen.height-mousePos.y,mouseTexture.width,mouseTexture.height),mouseTexture);
	}

}
