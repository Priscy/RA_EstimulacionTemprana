using UnityEngine;
using System.Collections;

public class UI_usuario: MonoBehaviour {
	public GameObject pantallaEntrar;
	public GameObject pantallaInicio;
	public UIButton cancelarButton;
	public UIButton entrarButton;
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
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);
	}
	void cancelarClicked () {
		pantallaEntrar.SetActive (false);
		pantallaInicio.SetActive (true);
	}
}
