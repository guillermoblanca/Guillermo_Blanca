using UnityEngine;
using System.Collections;

public class Disparo : MonoBehaviour {
	public GameObject proyectil; //laser que enlace con el prefab para disparar
	public float fuerzaProyectil; //determina la fuerza con la que se lanza el proyectil

	// Use this for initialization
	void Start () {

	}
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){ // realiza la funcion al pulsar el boton, una vez
			Debug.Log("Pulsado boton espacio");
			GameObject nuevoProyectil = (GameObject) Instantiate(proyectil, transform.position, transform.rotation);// instancia un objeto en la posicion del jugador
			nuevoProyectil.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, fuerzaProyectil)); // anade una fuerza determinada al proyectil
			nuevoProyectil.GetComponent<AudioSource>().Play();
			Destroy(nuevoProyectil,2);
		}
	}
}
