
using System.Collections;
using UnityEngine;

public class ComportamientoAgresivo : IComportamientoHollow{


	public ComportamientoAgresivo (){}

	public void comportarse (Animator anim, Rigidbody2D component, float velocidad){
        atacar(anim, component);
        mover(anim, velocidad);
    }

    private void atacar(Animator anim, Rigidbody2D component) {
        anim.SetFloat("caminar", 0.00f);
        anim.SetInteger("ataque", Random.Range(0, 3));
    }

    private void mover(Animator anim, float velocidad){
        anim.transform.Translate(Vector2.right * Time.deltaTime * velocidad * 1f);
        }

	public void cambiarComportamiento(Hollow hollow){
		hollow.setEstadoActual(new ComportamientoPacifico());
	}

	
}


	

