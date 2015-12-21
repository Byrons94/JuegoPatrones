using UnityEngine;
using System.Collections;

public class seguirJugador : MonoBehaviour {

	public Transform jugador;
	public float separacion = 2f;

	// Update is called once per frame
	void Update (){
		transform.position = new Vector3 (jugador.position.x + separacion, transform.position.y, transform.position.z);
	}
}
