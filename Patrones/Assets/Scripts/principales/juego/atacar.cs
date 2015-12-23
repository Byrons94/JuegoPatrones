using UnityEngine;
using System.Collections;

public class atacar : MonoBehaviour {
    int dano = 20;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Demi"){
            collision.collider.SendMessage("damage", dano);
        }
    }
}
