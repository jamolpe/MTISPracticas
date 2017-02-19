
/**
 * ServicioPractica1Skeleton.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis2 version: 1.6.3  Built on : Jun 27, 2015 (11:17:49 BST)
 */
    package org.example.www.serviciopractica1;

import java.util.Date;

/**
     *  ServicioPractica1Skeleton java skeleton for the axisService
     */
    public class ServicioPractica1Skeleton{
    	/**
    	 * Auto generated method signature
    	 * 
    	 * @param validarNIF
    	 * @return validarNIFResponse
    	 */

    	public org.example.www.serviciopractica1.ValidarNIFResponse validarNIF(
    			org.example.www.serviciopractica1.ValidarNIF validarNIF) {
    		
    		ValidarNIFResponse respuesta = new ValidarNIFResponse();
    		
    		if (ValidarClave.validar(validarNIF.localSoadKey)) {
    			RespuestaValidacionNif response = new RespuestaValidacionNif();

    			response.ValidacionNif = validarNIF;
    			respuesta = response.RealizarValidacionNIF();
    			respuesta.localMensaje = "";
    		} else {
    			respuesta.localMensaje = "Ha ocurrido un error al validar el NIF clave incorrecta";
    			respuesta.localValidado = false;
    		}
    		if(respuesta.localValidado==false){
    			respuesta.localMensaje="Validacion incorrecta DNI incorrecto";
    		}
    		return respuesta;

    	}
    	/**
    	 * Auto generated method signature
    	 * 
    	 * @param validarIBAN
    	 * @return validarIBANResponse
    	 * @throws Exception 
    	 */

    	public org.example.www.serviciopractica1.ValidarIBANResponse validarIBAN(
    			org.example.www.serviciopractica1.ValidarIBAN validarIBAN) throws Exception {
    			
    		ValidarIBANResponse respuesta = new ValidarIBANResponse();	

    		if (ValidarClave.validar(validarIBAN.localSoapKey)) {
    			RespuestaValidacionIBAN response = new RespuestaValidacionIBAN();
    			response.IBAN = validarIBAN;
    			respuesta = response.RealizarValidacionIBAN();
    			respuesta.localMensaje = "";
    			
    		}else{
    			respuesta.localValidado = false;
    			respuesta.localMensaje = "Ha ocurrido un error al validar el IBAN clave incorrecta";
    		}
    		
    		return respuesta;
    	}

    	/**
    	 * Auto generated method signature
    	 * 
    	 * @param consultaCodigoPostal
    	 * @return consultaCodigoPostalResponse
    	 */

    	public org.example.www.serviciopractica1.ConsultaCodigoPostalResponse consultaCodigoPostal(
    			org.example.www.serviciopractica1.ConsultaCodigoPostal consultaCodigoPostal) {
    			
    		ConsultaCodigoPostalResponse respuesta = new ConsultaCodigoPostalResponse();
    		if(ValidarClave.validar(consultaCodigoPostal.localSoapKey)){
    			RespuestaCodigoPostal respose = new RespuestaCodigoPostal();
    			respose.CODPOSTAL = consultaCodigoPostal;
    			respuesta.localMensaje="";
    			respuesta= respose.RealizarConsulta();
    			
    		}else{
    			respuesta.localCodPostal=consultaCodigoPostal.localCODPOS;
    			respuesta.localPoblacion="";
    			respuesta.localProvincia="";
    			respuesta.localMensaje="Ha ocurrido un error al consultar el codigo postal clave incorrecta";
    		}
    		
    		return respuesta;
    	}

    	/**
    	 * Auto generated method signature
    	 * 
    	 * @param generarPresupuesto
    	 * @return generarPresupuestoResponse
    	 */

    	public org.example.www.serviciopractica1.GenerarPresupuestoResponse generarPresupuesto(
    			org.example.www.serviciopractica1.GenerarPresupuesto generarPresupuesto) {
    		
    		GenerarPresupuestoResponse respuesta = new GenerarPresupuestoResponse();
    		if(ValidarClave.validar(generarPresupuesto.localSoapKey)){
    			RespuestaGenerarPresupuesto respose = new RespuestaGenerarPresupuesto();
    			respose.Presupuesto=generarPresupuesto;
    			respuesta.localMensaje="";
    			respuesta = respose.Generar();
    		}else{
    			respuesta.localIdPresupuesto=0;
    			respuesta.localPresupuestoGeneradoCorrectamente=false;
    			respuesta.localMensaje="Ha ocurrido un error al generar un presupuesto clave incorrecta";
    		}
    		
    		return respuesta;
    	}

     

    	public org.example.www.serviciopractica1.SolicitarPresupuestoResponse solicitarPresupuesto(
    			org.example.www.serviciopractica1.SolicitarPresupuesto solicitarPresupuesto) {
    		
    		SolicitarPresupuestoResponse respuesta = new SolicitarPresupuestoResponse();
    		if(ValidarClave.validar(solicitarPresupuesto.localSoapKey)){
    			RespuestaSolicitarPresupuesto respose = new RespuestaSolicitarPresupuesto();
    			respose.presupuesto=solicitarPresupuesto;
    			respuesta.localMensaje="";
    			respuesta= respose.solicitar();
    		}else{
    			respuesta.localDisponibilidadPieza=false;
    			respuesta.localFechaDisponibilidadPieza=new Date();
    			respuesta.localMensaje="Ha ocurrido un error al solicitar un presupuesto clave incorrecta";
    			respuesta.localPrecioPieza=0;
    		}
    		
    		return respuesta;
    	}

    }
    