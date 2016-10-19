using UnityEngine;
using System.Collections;

public class GameIfStartBoss : MonoBehaviour {

	public GameObject restEnemy;
	// Use this for initialization
	void Start () {
	

			
	}
	
	// Update is called once per frame
	void Update () {
		
		if (GameObject.FindWithTag("Enemy2") == null)
			Application.LoadLevel ("1stBoss");



	}
}
