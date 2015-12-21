using UnityEngine;
using System.Collections;

public class ControlJugador : MonoBehaviour {

	Jugador shinigami;
	Rigidbody2D component;

	Animator anim; // cambiar esto al final
	
	void Start () {
	 	anim = GetComponent<Animator>();
		component = GetComponent<Rigidbody2D>();
		shinigami = new Jugador(anim, component, 1, 100, "Ichigo");
	}
	
	// Update is called once per frame
	void FixedUpdate(){


		float move = Input.GetAxis("Horizontal");         
		shinigami.caminar(move);
		if (move > 0 && shinigami.getViendoDerecha()){
			shinigami.voltear();
			anim.SetBool("corriendo", false);
		}		
		else if (move < 0 && !shinigami.getViendoDerecha()){
			shinigami.voltear();
			anim.SetBool("corriendo", false);
		}

		if (Input.GetKeyDown(KeyCode.Space)){
			shinigami.saltar();
			anim.SetBool("corriendo", false);
		}

		anim.SetBool("atacar1", false);
		if(Input.GetKey(KeyCode.X)){
			shinigami.atacar();	
		}

		//correr 
		if ((move > 0 || move < 0) && Input.GetKey(KeyCode.LeftShift)){
			transform.Translate(Vector2.right * Time.deltaTime * move * 5f); 
			anim.SetBool("corriendo", true);
			component.velocity = new Vector3 (move * 5f, component.velocity.y);
		}	

	}
	//metodo que se encarga de las colisiones del jugador
	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "block" ){
			anim.SetBool("salto", false);
		}
	}
}
















