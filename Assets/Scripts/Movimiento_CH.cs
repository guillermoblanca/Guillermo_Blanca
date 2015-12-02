using UnityEngine;
using System.Collections;

public class Movimiento_CH : MonoBehaviour {
	public float  velocidad=1f;
	Rigidbody2D rg;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)){
			Mover_Izq(velocidad);
		}
		if (Input.GetKeyUp(KeyCode.A)){
			Mover_Izq(0);
		}
		if (Input.GetKey(KeyCode.D)){
			Mover_Drch(velocidad);
		}
		if (Input.GetKeyUp(KeyCode.D)){
			Mover_Drch(0);
		}
	}
	void Mover_Izq(float velocidad){
		rg.velocity  = new Vector2 (-velocidad, rg.velocity.y);
	}
	void Mover_Drch(float velocidad){
		rg.velocity  = new Vector2 (velocidad, rg.velocity.y);
	}
}
