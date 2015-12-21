using UnityEngine;
using System.Collections;

public class Shinigami {
	private Shinigami jugador;


	public Shinigami(int ptipo, int pvidaMaxima, string pnombre){}

	// Use this for initialization
	void Start () {
	    //jugador = new Shinigami(1,100, "Ichigo");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float move = Input.GetAxis("Horizontal");


		//transform.Translate(Vector2.right * Time.deltaTime * move* jugador.getVelocidad());    
		//jugador.caminar(anim, move);
		//anim.SetFloat ("speed", Mathf.Abs(move));
	}
}
