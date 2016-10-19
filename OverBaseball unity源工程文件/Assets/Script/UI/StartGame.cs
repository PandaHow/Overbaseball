using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public UI_choice UI_choice;


	void Start () {
		//Debug.Log(UI_choice.number);

		int levelNumber = UI_choice.number;
	}
	
	// Update is called once per frame
	void Update () {


		if (Input.GetMouseButtonDown (0))
		{
			if(UI_choice.number == 1) 
				Application.LoadLevel ("1st");
			if(UI_choice.number == 2) 
				Application.LoadLevel ("2nd");
			if(UI_choice.number == 3) 
				Application.LoadLevel ("3rd");
	}

	}
}
