
using System.Collections;
using UnityEngine;

public class ComportamientoAgresivo : IComportamientoHollow{


	public ComportamientoAgresivo (){}

		
	public void comportarse (Animator anim, Rigidbody2D component, float velocidad){
			anim.SetFloat("caminar", 0.00f);
			
		}
		
		public void cambiarComportamiento(Hollow hollow){
			hollow.setEstadoActual(new ComportamientoPacifico());
		}

		public string prueba(){
			return "agresivo";
		}
	}


	

