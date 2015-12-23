using UnityEngine;
using System.Collections;


    public class Ichigo : Shinigami{

    public Ichigo(Animator sprite, Rigidbody2D component, int ptipo, int pvidaMaxima, string pnombre,  bool viendoDerecha) 
            : base(sprite, component, ptipo, pvidaMaxima,  pnombre, 2f, 4f){
         
       }
}

