package org.example.www.serviciopractica1;

public class RespuestaValidacionNif {

	public ValidarNIF ValidacionNif;
	public ValidarNIFResponse Respuesta;
	
	
	RespuestaValidacionNif(){
		ValidacionNif = new ValidarNIF();
		Respuesta = new ValidarNIFResponse();
	}
	
	public ValidarNIFResponse RealizarValidacionNIF(){
		String juegoCaracteres="TRWAGMYFPDXBNJZSQVHLCKE";
		Respuesta.localValidado = false;
		
		if(ValidacionNif.localNIF.length()==9){
			int dni = Integer.parseInt(ValidacionNif.localNIF.substring(0,8));
			char letra= ValidacionNif.localNIF.charAt(8);
			int modulo= dni % 23;
			if(letra == juegoCaracteres.charAt(modulo)){
			Respuesta.localValidado=true;
			}
		}


		return Respuesta;
	}
	
	
}
