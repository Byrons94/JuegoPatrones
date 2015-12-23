using UnityEngine;
using System.Collections;

public class GeneradorEnemigos : MonoBehaviour {

	public GameObject [] obj;
	public float tiempoMinimo = 5f;
	public float tiempoMaximo = 10f;
    public int cantMaximaEnemigos = 3;

	void Start () {
		Generar();
	}
	
	void Generar(){
        int cantEnemigos = GameObject.FindGameObjectsWithTag("Demi").Length;
        if (cantEnemigos <= cantMaximaEnemigos) {

            int numeroRandom = Random.Range(0, obj.Length);
            Instantiate(obj[numeroRandom], transform.position, Quaternion.identity);
        }
        else if(cantEnemigos<=1){
            cantMaximaEnemigos = cantMaximaEnemigos + 2;
        }
        Invoke("Generar", Random.Range(tiempoMinimo, tiempoMaximo));
    }
}
