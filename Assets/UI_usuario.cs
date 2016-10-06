using UnityEngine;
using System;
using System.Collections;

public class UI_usuario: MonoBehaviour {
	public GameObject pantallaEntrar;
	public GameObject pantallaInicio;
	public UIButton cancelarButton;
	public UIButton entrarButton;
	//
	public UIInput nombre;
	public UIInput edad;
	public UIInput escuela;
	public UIInput password;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {
		pantallaEntrar.SetActive (true);

	}
	void OnEnable () {
		EventDelegate.Add (entrarButton.onClick,entrarClicked);
		EventDelegate.Add (cancelarButton.onClick,cancelarClicked);
	}
	void entrarClicked () {
		int num;
		bool res = int.TryParse(edad.value, out num);
		Usuario usuario = new Usuario (nombre.value,num,escuela.value,password.value);
		Debug.Log ("****************");
		Debug.Log ("---> "+usuario.nombre);
		Debug.Log ("---> "+usuario.edad);
		Debug.Log ("---> "+usuario.escuela);
		Debug.Log ("---> "+usuario.password);
		Session_App.validarUsuarios.Add (usuario.nombre,usuario);
		cleanValues ();
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);
	}
	void cancelarClicked () {
		cleanValues ();
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);
	}

	void cleanValues(){
		nombre.value = "";
		edad.value = "";
		escuela.value = "";
		password.value = "";
	}
}
