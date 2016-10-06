using UnityEngine;
using System.Collections;

public class Volver : MonoBehaviour {
	public UIButton volverButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnEnable () {
		EventDelegate.Add (volverButton.onClick,volver);
	}

	void OnDisable(){
		
	}

	void volver(){
		Application.LoadLevel ("00.Menu_CambiosEder");
	}
}
