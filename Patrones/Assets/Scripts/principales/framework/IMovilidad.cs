using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public interface IMovilidad{
	
	void caminar(float distancia);
	void correr();
	void voltear();
	void saltar();
	void atacar();
	//void recibirDamage();
}

