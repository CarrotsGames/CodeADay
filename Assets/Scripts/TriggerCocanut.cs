using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this makes sure their is a rigid body and will set gravity on

[RequireComponent(typeof(Rigidbody))]
public class TriggerCocanut : MonoBehaviour {
	private Rigidbody rbody;


	void Start () {
		rbody = GetComponent<Rigidbody> ();
		rbody.useGravity = false;

	}
	

	public void Fall () {
		rbody.useGravity = true;
	}
}
