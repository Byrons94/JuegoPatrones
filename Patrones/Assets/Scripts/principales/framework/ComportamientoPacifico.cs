
using System.Collections;
using UnityEngine;

	public class ComportamientoPacifico :IComportamientoHollow{

		public ComportamientoPacifico (){}
		

		public void comportarse (Animator anim, Rigidbody2D component, float velocidad){
				caminar(anim, component, velocidad);
			}

		private void caminar(Animator anim, Rigidbody2D component, float velocidad){
			anim.transform.Translate(Vector2.right * Time.deltaTime * velocidad * 2f); 
			anim.SetFloat("caminar", 1f);
			component.velocity = new Vector3 (1f *velocidad, component.velocity.y);
		}

		public void cambiarComportamiento(Hollow hollow){
			hollow.setEstadoActual(new ComportamientoAgresivo());
		}
		public string prueba(){
		return "pacifico";
		}
	}


