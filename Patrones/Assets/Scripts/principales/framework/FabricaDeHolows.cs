using UnityEngine;
using System.Collections;

	public class FabricaDeHolows : IFabricaEnemigos
	{
		public FabricaDeHolows (){}
	
		public Hollow crearHollow (string tipo, Animator anim, Rigidbody2D component){
			Hollow hollow;
			if(tipo == "Demi"){
				hollow = new DemiHollow(anim, component, 2, 50, tipo);
			}
			else if(tipo == "MenosGrande"){
				hollow = new MenosGrande(anim, component, 2, 100, tipo);
			}else {
				hollow =  null;
			}
		return hollow;
		}
	}

