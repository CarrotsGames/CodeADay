using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//this script is for adding a collider for the gravity script
public class TreeTrigger : MonoBehaviour {
	public TriggerCocanut cocanut;
	private Collider col;

	private bool hasTriggered;


	// Use this for initialization
	void Start () {

		col = GetComponent<Collider> ();

		if (col ==null) {
			Debug.Log (name + " Doesn't have a collider");
		}

		if (col.isTrigger ==false) {
			col.isTrigger = true;
		}
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider co) {
		if (co.transform != cocanut.transform && hasTriggered == false) {
			cocanut.Fall();
			hasTriggered = true;
		}
	}
}
