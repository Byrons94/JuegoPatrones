
using UnityEngine;
using System.Collections;

public class Hollow : Personaje{

	private float velocidad;
	private float velocidadMaxima;
	private bool  viendoDerecha;
	private Animator anim; //revisar
	private Rigidbody2D component;
	private IComportamientoHollow estadoActual;
	

	//poner las velocidades como parametros
	public Hollow (Animator anim, Rigidbody2D component, int ptipo, int pvidaMaxima, string pnombre) : base (ptipo,  pvidaMaxima, pnombre){
		setSprite(anim);
		setComponent(component);
		setVelocidad(1f);
		setVelocidadMaxima(4f);
		setViendoDerecha(true);
		setViendoDerecha(false);
		setEstadoActual(new ComportamientoPacifico());
	}


	private void setSprite(Animator psprite){
		anim = psprite;
	}
	private void setComponent(Rigidbody2D pcomponent){
		component = pcomponent;
	}
	private void setVelocidad(float pvelocidad){
		velocidad = pvelocidad;
	}
	private void setVelocidadMaxima(float pvelocidadMaxima){
		velocidadMaxima = pvelocidadMaxima;
	}
	private void setViendoDerecha(bool pviendoDerecha){
		viendoDerecha = pviendoDerecha;
	}

	public void setEstadoActual(IComportamientoHollow estado){
		estadoActual = estado;
	} 

	public void comportarse(){
		estadoActual.comportarse(getSprite(), getComponent(), getVelocidad());
	}
	
	public void cambiarComportamiento(){
		estadoActual.cambiarComportamiento(this);
	}

	public IComportamientoHollow getEstado(){
		return estadoActual;
	}

	public void voltear(){
		setViendoDerecha(!getViendoDerecha());
		setVelocidad(getVelocidad()*-1);
		Vector3 theScale = anim.transform.localScale;
		theScale.x *=  -1;
		anim.transform.localScale = theScale;
	}

	//gets
	public float getVelocidad(){
		return velocidad;
	}
	public float getVelocidadMaxima(){
		return velocidadMaxima;
	}
	public bool getViendoDerecha(){
		return viendoDerecha;
	}
	
	public Animator getSprite(){
		return anim;
	}
	
	private Rigidbody2D getComponent(){
		return component;
	}
}

