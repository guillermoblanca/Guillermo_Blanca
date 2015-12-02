using UnityEngine;
using System.Collections;

public class Generador : MonoBehaviour {
    public float minimo = -1f; // Limite por la derecha del generador
    public float maximo = 1f; // Límite por la izquierda del generador
    public float tiempo = 2f; // Tiempo entre enemigos
    public GameObject enemigo; // Enemigo a generar

    private float siguiente_enemigo = 0;
	
	void Start () {
        siguiente_enemigo = tiempo;
	}
	
	
	void Update () {
	    if(siguiente_enemigo < Time.time)
        {
            Vector3 posicion = new Vector3(transform.position.x + Random.Range(minimo, maximo), transform.position.y, transform.position.z);
            siguiente_enemigo = Time.time + tiempo;
            Instantiate(enemigo, posicion, transform.rotation);
        }
	}

    // Para visualizar los limites en el editor
    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.yellow;
        Gizmos.DrawLine(new Vector3(transform.position.x+maximo, transform.position.y,transform.position.z), new Vector3(transform.position.x +minimo, transform.position.y, transform.position.z));
    }
}
