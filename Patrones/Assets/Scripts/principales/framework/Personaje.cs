using UnityEngine;
using System.Collections;

	public class Personaje{
		private int tipo;
		private int vidaMaxima;
		private int vidaActual;
		private bool estaVivo; //estado
		private string nombre;
		private Animator Anim;
	
		public Personaje(int ptipo, int pvidaMaxima, string pnombre){
			setTipo(ptipo);
			setVidaMaxima(pvidaMaxima);
			setNombre(pnombre);
		}

		private void setTipo(int ptipo){
			tipo = ptipo;
		}
		private void setVidaMaxima(int pvidaMax){
			vidaMaxima = pvidaMax;
		}
		private void setNombre(string pnombre){
			nombre = pnombre;
		}
		public void setEstaVivo(bool pvivo){
			estaVivo = pvivo;
		}
		public void setVidaActual(int pvidaActual){
			vidaActual = pvidaActual;
		}

		public int getTipo(){
			return tipo;
		}
		public int getVidaMaxima(){
			return vidaMaxima;
		}
		public string getNombre(){
			return nombre;
		}
		public bool getEstaVivo(){
			return estaVivo;
		}
		public int getVidaActual(){
			return vidaActual;
		}
	}

