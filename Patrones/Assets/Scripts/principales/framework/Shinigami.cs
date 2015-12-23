using UnityEngine;
using System.Collections;
//clase encargada de la manipulacion del personaje que la herede.
public class Shinigami : Personaje, IMovilidad {

    private float velocidad;
    private float velocidadMaxima;
    private bool viendoDerecha;
    private Animator sprite;
    private Rigidbody2D component;

    //constructor
    public Shinigami(Animator sprite, Rigidbody2D component, int ptipo, int pvidaMaxima, string pnombre, float velocidad, float velocidadMaxima)
                    : base(ptipo, pvidaMaxima, pnombre) {
        setSprite(sprite);
        setComponent(component);
        setVelocidad(velocidad);
        setVelocidadMaxima(velocidadMaxima);
        setViendoDerecha(false);
    }

    //sets
    private void setSprite(Animator psprite) {
        sprite = psprite;
    }
    private void setComponent(Rigidbody2D pcomponent) {
        component = pcomponent;
    }
    private void setVelocidad(float pvelocidad) {
        velocidad = pvelocidad;
    }
    private void setVelocidadMaxima(float pvelocidadMaxima) {
        velocidadMaxima = pvelocidadMaxima;
    }
    public void setViendoDerecha(bool pviendoDerecha) {
        viendoDerecha = pviendoDerecha;
    }

    //gets
    public float getVelocidad() {
        return velocidad;
    }
    public float getVelocidadMaxima() {
        return velocidadMaxima;
    }
    public bool getViendoDerecha() {
        return viendoDerecha;
    }

    public Animator getSprite() {
        return sprite;
    }

    private Rigidbody2D getComponent() {
        return component;
    }

    //implementados de IMovilidad
    public void caminar(float distancia) {
        sprite.transform.Translate(Vector2.right * Time.deltaTime * distancia * getVelocidad());
        sprite.SetFloat("speed", Mathf.Abs(distancia));
        component.velocity = new Vector3(distancia * velocidad, component.velocity.y);
    }

    public void voltear() {
        setViendoDerecha(!getViendoDerecha());
        Vector3 theScale = sprite.transform.localScale;
        theScale.x *= -1;
        sprite.transform.localScale = theScale;
    }

    public void saltar() {
        if (sprite.GetBool("salto") == false) {
            sprite.SetBool("salto", true);
            component.AddForce(Vector3.up * 10, ForceMode2D.Impulse);
        }
    }

    public void correr(float move) {
        component.transform.Translate(Vector2.right * Time.deltaTime * move * 5f);
        sprite.SetBool("corriendo", true);
        component.velocity = new Vector3(move * 5f, component.velocity.y);
    }

    public void ataqueNormal() {
        if (sprite.GetBool("atacar1") == false) {
            sprite.SetBool("atacar1", true);
        }
    }

    public void ataqueFuerte() {
        if (sprite.GetBool("atacar2") == false) {
            sprite.SetBool("atacar2", true);
        }
    }

    public void recibirDano(int dmg) {
        setVidaActual(getVidaActual() - dmg);
        puntaje.vidaActual = getVidaActual();
    }
}
