using UnityEngine;
using System.Collections;

public class GeneradorEnemigos : MonoBehaviour {

	public GameObject [] obj;
	public float tiempoMinimo = 30f;
	public float tiempoMaximo = 60f;

	void Start () {
		Generar();
	}
	
	void Generar(){
		int numeroRandom = Random.Range(0, obj.Length);
		Instantiate(obj[numeroRandom], transform.position, Quaternion.identity);
		//Invoke("Generar", Random.Range(tiempoMinimo, tiempoMaximo));
	}
}
