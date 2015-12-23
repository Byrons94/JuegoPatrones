using UnityEngine;
using System.Collections;

public class ControlEnemigo : MonoBehaviour {
	private Animator anim;
	private Rigidbody2D  component;
	private FabricaDeHolows fabrica;
	private Hollow enemigo;
	private GameObject shinigami;
	private float maxRange = 5f;
	private bool rango = false;

	void Start () {
		string tipoHollow = this.tag.ToString();
		anim 	  = GetComponent<Animator>();
		component = GetComponent<Rigidbody2D>();

		fabrica	  = new FabricaDeHolows();
		enemigo   = fabrica.crearHollow(tipoHollow, anim, component);
		shinigami = GameObject.FindGameObjectWithTag("Ichigo");
		if(enemigo==null){
			Destroy(this);
		}
	}
    
    

	void Update (){
        if (enemigo.getVidaActual() <= 0) {
            puntaje.score += 1;
            Destroy(gameObject);
        }
        
        if ((Vector3.Distance(transform.position, shinigami.transform.position) <= maxRange) && !rango){
           
            enemigo.cambiarComportamiento();
            rango = true;

            if (shinigami.transform.position.x < transform.position.x && !enemigo.getViendoDerecha()
                    || shinigami.transform.position.x >= transform.position.x && enemigo.getViendoDerecha()){
                enemigo.voltear();
            }
        }
        else if ((Vector3.Distance(transform.position, shinigami.transform.position) > maxRange) && rango){
            enemigo.cambiarComportamiento();

            rango = false;
        }
        enemigo.comportarse();
	}

    void OnCollisionEnter2D(Collision2D coll){
		if(coll.gameObject.tag == "limites"){
			enemigo.voltear();
		}
	}

    void damage(int dano) {
        enemigo.recibirDano(dano);
    }
}
