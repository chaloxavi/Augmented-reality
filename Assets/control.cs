using System.Collections;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour {
	public void camEsc(string nombre){
		SceneManager.LoadScene (nombre);
	}

	public void salir(){
		Application.Quit ();
	
	}
}
