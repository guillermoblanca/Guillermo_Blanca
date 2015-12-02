using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntuacion : MonoBehaviour {
	public Text textoPuntuacion;
	public int puntos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		textoPuntuacion.text = ""+puntos;
	}
	public void Suma_Puntos(){
		puntos= puntos+ 1;
	}

}
