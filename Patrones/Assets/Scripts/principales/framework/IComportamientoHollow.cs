
  using UnityEngine;	
  using System.Collections;

	public interface IComportamientoHollow{
		
	void comportarse(Animator anim, Rigidbody2D component, float  velocidad);
	void cambiarComportamiento(Hollow hollow);
	string prueba();
	}