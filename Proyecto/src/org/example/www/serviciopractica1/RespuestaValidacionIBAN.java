package org.example.www.serviciopractica1;

public class RespuestaValidacionIBAN {
		
	public ValidarIBANResponse respuesta;
	public ValidarIBAN IBAN;
	
	RespuestaValidacionIBAN(){
		respuesta = new ValidarIBANResponse();
		IBAN = new ValidarIBAN();
	}
	
	public ValidarIBANResponse RealizarValidacionIBAN() throws Exception{
		
		try{
			respuesta.localValidado= destriparIban(IBAN.localIBAN);
		}catch(Exception e){
			respuesta.localValidado= false;
			respuesta.localMensaje= "Ha ocurrido una excepcion " + e;
		}
		
				
		return respuesta;
	}
	
	
	 public static Boolean destriparIban(String iban) throws Exception {
	        if (iban.length() == 24) {
	            return validarCuentaES(iban.substring(4, 24));
	        } else {
	        	return false;
	        }
	    }
	    
	    public static Boolean validarCuentaES(String ccc) throws Exception {
	        try {
	            String banco = ccc.substring(0, 4);
	            String oficina = ccc.substring(4, 8);
	            String dc = ccc.substring(8, 10);
	            String cuenta = ccc.substring(10, 20);
	            if (!dc.equals(ObtenerDC(banco, oficina, cuenta))) {
	                return false;
	            } else if ("0000".equals(banco) || "0000".equals(oficina) || "0000000000".equals(cuenta)) {
	                return false;
	            } else {
	                return true;
	            }
	        } catch (StringIndexOutOfBoundsException e) {
	            System.err.println(e.getMessage());
	            return false;
	        }
	    }
	    
	    public static String ObtenerDC(String banco, String oficina, String cuenta) throws StringIndexOutOfBoundsException {
	        int temp;
	        String dg1, dg2;
	        temp = 0;

	        temp += Integer.parseInt(banco.substring(0, 1)) * 4;
	        temp += Integer.parseInt(banco.substring(1, 2)) * 8;
	        temp += Integer.parseInt(banco.substring(2, 3)) * 5;
	        temp += Integer.parseInt(banco.substring(3, 4)) * 10;
	        temp += Integer.parseInt(oficina.substring(0, 1)) * 9;
	        temp += Integer.parseInt(oficina.substring(1, 2)) * 7;
	        temp += Integer.parseInt(oficina.substring(2, 3)) * 3;
	        temp += Integer.parseInt(oficina.substring(3, 4)) * 6;

	        temp = 11 - temp % 11;
	        switch (temp) {
	            case 10:
	                dg1 = String.valueOf(1);
	                break;
	            case 11:
	                dg1 = String.valueOf(0);
	                break;
	            default:
	                dg1 = String.valueOf(temp);
	                break;
	        }
	        temp = 0;

	        temp += Integer.parseInt(cuenta.substring(0, 1)) * 1;
	        temp += Integer.parseInt(cuenta.substring(1, 2)) * 2;
	        temp += Integer.parseInt(cuenta.substring(2, 3)) * 4;
	        temp += Integer.parseInt(cuenta.substring(3, 4)) * 8;
	        temp += Integer.parseInt(cuenta.substring(4, 5)) * 5;
	        temp += Integer.parseInt(cuenta.substring(5, 6)) * 10;
	        temp += Integer.parseInt(cuenta.substring(6, 7)) * 9;
	        temp += Integer.parseInt(cuenta.substring(7, 8)) * 7;
	        temp += Integer.parseInt(cuenta.substring(8, 9)) * 3;
	        temp += Integer.parseInt(cuenta.substring(9, 10)) * 6;

	        temp = 11 - temp % 11;
	        switch (temp) {
	            case 10:
	                dg2 = String.valueOf(1);
	                break;
	            case 11:
	                dg2 = String.valueOf(0);
	                break;
	            default:
	                dg2 = String.valueOf(temp);
	                break;
	        }
	        return String.valueOf(dg1) + String.valueOf(dg2);
	    }
}
