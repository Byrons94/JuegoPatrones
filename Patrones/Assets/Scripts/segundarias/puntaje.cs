using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class puntaje : MonoBehaviour {

    public static int score;
    public static int vidaActual;

    Text text;
    Text texto2;
    public Text[] texts;
    public Canvas canvas;

    void Awake(){
        // Set up the reference.
        texts = canvas.gameObject.GetComponentsInChildren<Text>();

        text = texts[0];
        texto2 = texts[1];

        // Reset the score.
        score = 0;
        vidaActual = 100;
    }

    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
        texto2.text = "Vida Actual: " + vidaActual;
    }
}
