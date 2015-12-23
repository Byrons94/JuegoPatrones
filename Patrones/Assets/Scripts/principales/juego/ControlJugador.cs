using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ControlJugador : MonoBehaviour {

	Shinigami shinigami;
	Rigidbody2D component;
	Animator anim;
    private bool atacando = false;
    private float tiempoAtaque = 0f;
    private float atactCd = 0.3f;
    public Collider2D atactTriger;

	void Start () {
	 	anim = GetComponent<Animator>();
		component = GetComponent<Rigidbody2D>();
		shinigami = new Ichigo(anim, component, 1, 100, "Ichigo", false);
        atactTriger.enabled = false;
	}


    void Update() {

        if (shinigami.getVidaActual() <= 0){
            LoadScene();
            Destroy(gameObject);
        }
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


        if (Input.GetKeyDown(KeyCode.Space))
        {
            shinigami.saltar();
            anim.SetBool("corriendo", false);
        }


        anim.SetBool("atacar1", false);
        anim.SetBool("atacar2", false);
        if (Input.GetKey(KeyCode.X) && !atacando){
            shinigami.ataqueNormal();

            atacando = true;
            tiempoAtaque = atactCd;
            atactTriger.enabled = true;
        }

        if (Input.GetKey(KeyCode.Z) && !atacando){
            shinigami.ataqueFuerte();

            atacando = true;
            tiempoAtaque = atactCd;
            atactTriger.enabled = true;
        }
        tiempoAtaqueE(move);
    }

    private void tiempoAtaqueE(float move) {
        if (atacando)
        {
            if (tiempoAtaque > 0)
            {
                tiempoAtaque -= Time.deltaTime;
            }
            else
            {
                atacando = false;
                atactTriger.enabled = false;
            }
        }


        if ((move > 0 || move < 0) && Input.GetKey(KeyCode.LeftShift))
        {
            shinigami.correr(move);
        }
    }

    private void LoadScene(){
        Application.LoadLevel("gameOver");
    }


	void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject.tag == "block" || collision.gameObject.tag == "Demi"){
			anim.SetBool("salto", false);
		}
	}


    void recibirAtaque(int dano){
        shinigami.recibirDano(dano);
    }
}
















