using UnityEngine;
using System.Collections;

public class ataqueEnemigo : MonoBehaviour {
    int dano = Random.Range(1,2);

    void OnCollisionEnter2D(Collision2D collision){

        if (collision.gameObject.tag == "Ichigo"){
            collision.collider.SendMessage("recibirAtaque", dano);
        }

    }
}
