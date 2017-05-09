using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class PlayAnimation : MonoBehaviour {
	public string animationName;

	private Animator animator;
	private Collider col;

	private bool hasTriggered;


	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

		col = GetComponent<Collider> ();

		if (col ==null) {
			Debug.Log (name + " Doesn't have a collider");
		}

		if (col.isTrigger ==false) {
			col.isTrigger = true;
		}
	}
	
	void OnTriggerEnter(){
		if(hasTriggered == false){
			animator.Play (animationName);
			hasTriggered = true;	
		}
	}
}
