package org.example.www.serviciopractica1;

public class RespuestaCodigoPostal {
	
	public ConsultaCodigoPostal CODPOSTAL;
	
	RespuestaCodigoPostal(){
		CODPOSTAL= new ConsultaCodigoPostal();
	}
	
	public ConsultaCodigoPostalResponse RealizarConsulta(){
		return TrabajarBD.ComprobarCodigoPostal(CODPOSTAL.localCODPOS);
	}
}
