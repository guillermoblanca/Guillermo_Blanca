using UnityEngine;
using System.Collections;

public class Movimiento_CH : MonoBehaviour {
	public float  velocidad=1f;
	public GameObject animacion_explosion;
	Rigidbody2D rg;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () { //funciones de moton
		if (Input.GetKey(KeyCode.A)){
			Mover_Izq(velocidad); // carga la velocidad
		}
		if (Input.GetKeyUp(KeyCode.A)){
			Mover_Izq(0); //reduce a cero la velocidad para parar en seco
		}
		if (Input.GetKey(KeyCode.D)){
			Mover_Drch(velocidad);
		}
		if (Input.GetKeyUp(KeyCode.D)){
			Mover_Drch(0);
		}
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Enemigo"){
			GameObject animacion = (GameObject) Instantiate(animacion_explosion, transform.position, transform.rotation);
			Destroy(gameObject,1);
			Destroy(animacion,1);
		}
	}
	void Mover_Izq(float velocidad){ // mueve a la izquierda
		rg.velocity  = new Vector2 (-velocidad, rg.velocity.y); // utiliza la velocidad para que sea un movimiento fluido y no pegue saltos
	}
	void Mover_Drch(float velocidad){ // mueve a la derecha
		rg.velocity  = new Vector2 (velocidad, rg.velocity.y);
	}

}
