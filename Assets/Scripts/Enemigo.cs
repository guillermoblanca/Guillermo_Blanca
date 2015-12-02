using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
	Rigidbody2D rg;
	public float velocidadEnemigo=1f;
	public GameObject animacion_explosion;
	bool muerto;
	Puntuacion pt;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		muerto= false;
		rg = GetComponent<Rigidbody2D>();
		pt = GameObject.FindWithTag ("Puntuacion").GetComponent<Puntuacion>();
		audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		rg.velocity = new Vector2 (0, -velocidadEnemigo);
		if (muerto){
			pt.Suma_Puntos();
			audio.Play();
			muerto = false;
		}
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Laser"){
			GameObject animacion = (GameObject) Instantiate(animacion_explosion, transform.position, transform.rotation);
			velocidadEnemigo = 0;
			muerto = true;
			Destroy(gameObject,0.5f);
			Destroy(animacion,0.5f);
		
		}
	}
}
