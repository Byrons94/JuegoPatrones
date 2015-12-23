using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public interface IMovilidad{
	
	void caminar(float distancia);
	void correr(float move);
	void voltear();
	void saltar();
	void ataqueNormal();
}

