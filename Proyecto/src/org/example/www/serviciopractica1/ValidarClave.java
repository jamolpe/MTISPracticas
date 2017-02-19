package org.example.www.serviciopractica1;

public class ValidarClave {
	
	
	public static boolean validar(String clave){
	
		return TrabajarBD.ComprobarClave(clave);
	}
}
