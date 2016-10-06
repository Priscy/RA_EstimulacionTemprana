using UnityEngine;
using System.Collections;

public class Usuario {
	public string nombre="";
	public int edad=0;
	public string escuela = "";
	public string password = "";

	public Usuario(){
	}

	public Usuario(string nombre,int edad,string escuela,string password){
		this.nombre = nombre;
		this.edad = edad;
		this.escuela = escuela;
		this.password = password;
	}

}
