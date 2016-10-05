using UnityEngine;
using System.Collections;

public class UI_entrar : MonoBehaviour {
	public GameObject pantallaEntrar;
	public GameObject pantallaInicio;
	public UIButton entrarButton;
	public UIButton salirButton;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		pantallaEntrar.SetActive (true);

	}
	void OnEnable () {
		EventDelegate.Add (entrarButton.onClick,entrarClicked);
		EventDelegate.Add (salirButton.onClick, salirClicked);

	}
	void entrarClicked () {
		Application.LoadLevel ("RA");		
		Debug.Log ("RA");
	}
	void salirClicked () {
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);

	}
}
