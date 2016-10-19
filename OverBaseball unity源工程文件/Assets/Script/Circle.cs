using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEditorInternal;
using UnityEngineInternal;

public class Circle : MonoBehaviour
{

	public Transform player;
	public Vector3 offset ;


	void Start () {

		player = GameObject.Find ("Player").GetComponent<Transform> ();
		offset = player.position - this.transform.position;

	}


	void Update(){

		this.transform.position = player.position - offset;

	}






}


