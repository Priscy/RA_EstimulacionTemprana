using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using TouchScript.Gestures;

public class Card: MonoBehaviour{
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	private void OnEnable(){
		GetComponent<TapGesture> ().Tapped += tappedHandler;

		Debug.Log ("Enable tap gesture");
	}

	private void OnDisable(){
		GetComponent<TapGesture> ().Tapped -= tappedHandler;
	}

	private void tappedHandler(object sender, EventArgs e){
		Debug.Log ("Car has been tapped");
		this.transform.FindChild ("Modelo").gameObject.SetActive (true);
	}
}
