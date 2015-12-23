using UnityEngine;
using System.Collections;

	public class Personaje{
		private int tipo;
		private int vidaMaxima;
		private int vidaActual;
		private string nombre;
		
		public Personaje(int ptipo, int pvidaMaxima, string pnombre){
			setTipo(ptipo);
			setVidaMaxima(pvidaMaxima);
            setVidaActual(100);
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
		
		public int getVidaActual(){
			return vidaActual;
		}
	}

