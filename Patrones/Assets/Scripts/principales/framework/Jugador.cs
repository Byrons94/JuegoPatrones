using UnityEngine;
using System.Collections;
//clase encargada de la manipulacion del personaje que la herede.
public class Jugador:  Personaje, IMovilidad{
	
	private float velocidad;
	private float velocidadMaxima;
	private bool  viendoDerecha;
	private Animator sprite; //revisar
	private Rigidbody2D component;

	//constructor
	public Jugador(Animator sprite, Rigidbody2D component, int ptipo, int pvidaMaxima, string pnombre) : base( ptipo,  pvidaMaxima, pnombre){
		setSprite(sprite);
		setComponent(component);
		setVelocidad(2f);
		setVelocidadMaxima(4f);
		setViendoDerecha(true);
		setViendoDerecha(false);
	}
	
	//sets
	private void setSprite(Animator psprite){
		sprite = psprite;
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
		return sprite;
	}

	private Rigidbody2D getComponent(){
		return component;
	}
	
	//implementados de IMovilidad
	public void caminar(float distancia){
		sprite.transform.Translate(Vector2.right * Time.deltaTime * distancia * getVelocidad()); 
		sprite.SetFloat ("speed", Mathf.Abs(distancia));
		component.velocity = new Vector3 (distancia * velocidad, component.velocity.y);
	}

	public void voltear(){
		setViendoDerecha(!getViendoDerecha());
		Vector3 theScale = sprite.transform.localScale;
		theScale.x *=  -1;
		sprite.transform.localScale = theScale;
	}

	public void saltar(){
		if(sprite.GetBool("salto") == false){
			sprite.SetBool("salto", true);
			component.AddForce(Vector3.up * 10, ForceMode2D.Impulse);
		}
	}

    public void correr(){
		if(sprite.GetBool("salto") == false){
			sprite.SetBool("salto", true);
			component.AddForce(Vector3.up * 10, ForceMode2D.Impulse);
		}
	}

	public void atacar(){
		if(sprite.GetBool("atacar1") == false){
			sprite.SetBool("atacar1", true);
		}
	}

	public void recibirAtaque(){}
   
    
}
