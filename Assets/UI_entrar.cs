using UnityEngine;
using System.Collections;

public class UI_entrar : MonoBehaviour {
	public GameObject pantallaEntrar;
	public GameObject pantallaInicio;
	public UIButton entrarButton;
	public UIButton salirButton;
	//
	public UIInput nombre;
	public UIInput password;
	public UILabel warning;
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
		warning.gameObject.SetActive (false);
	}
	void entrarClicked () {
		bool permite = validarUsuario ();
		if (permite) {
			Application.LoadLevel ("RA");		
			Debug.Log ("RA");
		} else {
			warning.gameObject.SetActive (true);
		}
	}
	void salirClicked () {
		cleanValues ();
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);

	}

	void cleanValues(){
		nombre.value = "";
		password.value = "";
	}

	bool validarUsuario(){
		bool returnValue = Session_App.validarUsuarios.ContainsKey(nombre.value);
		if(returnValue){
			Usuario usuario = Session_App.validarUsuarios [nombre.value];
			if(!password.value.Equals(usuario.password)){
				returnValue = false;
			}
		}

		return returnValue;
	}
}
