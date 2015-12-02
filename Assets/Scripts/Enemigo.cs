using UnityEngine;
using System.Collections;

public class Enemigo : MonoBehaviour {
	Rigidbody2D rg;
	public float velocidadEnemigo=1f;
	// Use this for initialization
	void Start () {
		rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		rg.velocity = new Vector2 (0, -velocidadEnemigo);
	}
	void OnTriggerEnter2D(Collider2D objeto){
		if (objeto.transform.tag == "Laser"){
			Debug.Log ("laser");
			Destroy(gameObject);
		}
	}
}
