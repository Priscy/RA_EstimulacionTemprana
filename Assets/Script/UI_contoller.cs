using UnityEngine;
using System.Collections;

public class UI_contoller : MonoBehaviour {
	public GameObject inicio;
	public GameObject pantallaEntrar;
	public GameObject crearUsuario;
	public UIButton entrar;
	public UIButton crear;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		inicio.SetActive (true);
		pantallaEntrar.SetActive (false);
		crearUsuario.SetActive (false);
	}
	void OnEnable () {
		EventDelegate.Add (entrar.onClick,entrarClicked);
		EventDelegate.Add (crear.onClick,crearClicked);
	}
	void entrarClicked () {
		pantallaEntrar.SetActive (true);
		inicio.SetActive (false);
		Debug.Log ("pantalla entrar activa");
	}
	void crearClicked () {
		inicio.SetActive (false);
		crearUsuario.SetActive (true);
		Debug.Log ("pantalla crear usuario activa");		
	}
}
