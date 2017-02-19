package org.example.www.serviciopractica1;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
public class TrabajarBD {
	private static ResultSet resultSet = null;
	private static int resultadoInsert = 0;
	private static Connection connection = null;
	private static Statement statement = null;
	private static PreparedStatement preparedStatement = null;
	
	
	private static void EjecutarComando(String comando){
		
		
		
		try {
			Class.forName("com.mysql.jdbc.Driver");
		}catch(Exception e) {
			System.out.println("Unable to load Driver");
			resultSet = null;
		}
		
		//Establish connection using DriverManager 
		try {
		 connection = 
	        DriverManager.getConnection("jdbc:mysql://localhost/MTIS", "root", "");
		} catch (SQLException e) {
			System.out.println("Unable to connect to database");
			resultSet = null;
		}
		
		//if connection is successfully established, create statement
        if(connection != null) {
	    try {
	       statement = connection.createStatement();
	    } catch (SQLException e) {
	       System.out.println("Unable to create statement");
	       resultSet = null;
	    }
	    
	}
        //if statement is created successfully, execute query and get results
        if(statement != null) {
	   try {
	        resultSet = statement.executeQuery(comando);
	   } catch (SQLException e) {
	        System.out.println("Unable to create statement");
	        resultSet = null;
	       
	   }
        }
        
       
	}
	
	private static void EjecutarComandoInsert(String comando){
		
		
		
		try {
			Class.forName("com.mysql.jdbc.Driver");
		}catch(Exception e) {
			System.out.println("Unable to load Driver");
			resultSet = null;
		}
		
		//Establish connection using DriverManager 
		try {
		 connection = 
	        DriverManager.getConnection("jdbc:mysql://localhost/MTIS", "root", "");
		} catch (SQLException e) {
			System.out.println("Unable to connect to database");
			resultSet = null;
		}
		
		//if connection is successfully established, create statement
        if(connection != null) {
	    try {
	    	preparedStatement =  connection.prepareStatement(comando);
	    } catch (SQLException e) {
	       System.out.println("Unable to create statement");
	       resultSet = null;
	    }
	    
	}
        //if statement is created successfully, execute query and get results
        if(preparedStatement != null) {
	   try {
		   resultadoInsert = preparedStatement.executeUpdate();
	   } catch (SQLException e) {
	        System.out.println("Unable to create statement");
	        resultSet = null;
	       
	   }
        }
        
       
	}
	

	public static Boolean ComprobarClave(String clave){

		Boolean correcta=false;
		
		String comando = "Select 1 from claveacceso where clave="+clave;
        EjecutarComando(comando);

       	// iterate over resultset to get values
            if(resultSet != null) {
            	correcta =  true;
            	try {
					resultSet.close();
				} catch (SQLException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
    	}
            try {
				statement.close();
				connection.close();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
			
            
            return correcta;

	}
	
	public static ConsultaCodigoPostalResponse ComprobarCodigoPostal(String CodPostal){
		
		ConsultaCodigoPostalResponse respuesta = new ConsultaCodigoPostalResponse();
		
		respuesta.localCodPostal=CodPostal;
		respuesta.localPoblacion = "";
		respuesta.localProvincia = "";
		respuesta.localMensaje="";
		String comando = "Select poblacion,provincia from codigospostales where codigoPostal="+ CodPostal;
		 EjecutarComando(comando);

	       	// iterate over resultset to get values
	            if(resultSet != null) {
	            	try {
	            		resultSet.next();
						respuesta.localPoblacion = resultSet.getString(1);
						respuesta.localProvincia = resultSet.getString(2);
					} catch (SQLException e) {
						respuesta.localPoblacion="";
						respuesta.localProvincia="";
						respuesta.localMensaje="Ha ocurrido un error "+ e;
						e.printStackTrace();
					}
	            	
	            	try {
						resultSet.close();
					} catch (SQLException e) {
						respuesta.localPoblacion="";
						respuesta.localProvincia="";
						respuesta.localMensaje="Ha ocurrido un error "+ e;
						e.printStackTrace();
					}
	    	}
	            try {
					statement.close();
					connection.close();
				} catch (SQLException e) {
					respuesta.localPoblacion="";
					respuesta.localProvincia="";
					respuesta.localMensaje="Ha ocurrido un error "+ e;
					e.printStackTrace();
				}
				
	            return respuesta;
	}
	
	public static GenerarPresupuestoResponse GenerarPresupuestoBD(GenerarPresupuesto presupuesto){
		
		GenerarPresupuestoResponse respuesta = new GenerarPresupuestoResponse();
		java.text.SimpleDateFormat sdf = 
			     new java.text.SimpleDateFormat("yyyy-MM-dd");		
		String currentTime = sdf.format(presupuesto.localFechaPresupuesto);
		String comando = "Insert into presupuestos(idCliente, referenciaProducto, cantidadProducto, fechaPresupuesto) values("
		+ presupuesto.localIdCliente+" ,'"+presupuesto.localReferenciaProducto +"',"+presupuesto.localCantidadProducto+",'"+currentTime+"');";
		respuesta.localMensaje="";
		EjecutarComandoInsert(comando);
		
		if(resultadoInsert != 0){
			String comando2 = "Select id from presupuestos where referenciaProducto='"+ presupuesto.localReferenciaProducto+ "' and idCliente="+ presupuesto.localIdCliente +";";
			EjecutarComando(comando2);
			
			if(resultSet != null){
				try{
					resultSet.next();
					respuesta.localIdPresupuesto= Integer.parseInt(resultSet.getString(1)) + 1;
					respuesta.localPresupuestoGeneradoCorrectamente=true;
				}catch(Exception e){
					respuesta.localIdPresupuesto=0;
					respuesta.localPresupuestoGeneradoCorrectamente=false;
					respuesta.localMensaje="Ha ocurrido un error "+ e;
				}
				
				try {
					resultSet.close();
				} catch (SQLException e) {
					respuesta.localIdPresupuesto=0;
					respuesta.localPresupuestoGeneradoCorrectamente=false;
					respuesta.localMensaje="Ha ocurrido un error "+ e;
					e.printStackTrace();
				}
				
			}else{
				respuesta.localIdPresupuesto=0;
				respuesta.localPresupuestoGeneradoCorrectamente=false;
			}
		}
		
		try {
			statement.close();
			connection.close();
		} catch (SQLException e) {
			respuesta.localIdPresupuesto=0;
			respuesta.localPresupuestoGeneradoCorrectamente=false;
			e.printStackTrace();
		}

		return respuesta;
	}
	
	public static SolicitarPresupuestoResponse SolicitarPresupuestoBD(SolicitarPresupuesto presupuesto){
		SolicitarPresupuestoResponse respuesta = new SolicitarPresupuestoResponse();
		
		respuesta.localMensaje="";
		respuesta.localDisponibilidadPieza=false;
		respuesta.localFechaDisponibilidadPieza=null;
		respuesta.localPrecioPieza=0;
		String comando = "Select precioPieza,disponibilidadPieza,fechaDisponibilidad from piezas where referenciaPieza= '"+ presupuesto.localReferenciaPieza + "' and idProveedor="+ presupuesto.localIdProveedor;
		EjecutarComando(comando);

		if(resultSet!=null){
			try {
				resultSet.next();
				respuesta.localPrecioPieza = resultSet.getInt(1);
				respuesta.localDisponibilidadPieza = resultSet.getBoolean(2);
				respuesta.localFechaDisponibilidadPieza = resultSet.getDate(3);
				
			} catch (SQLException e) {
				respuesta.localMensaje="Ha ocurrido un error "+e;
				e.printStackTrace();
			}
			
        	try {
				resultSet.close();
			} catch (SQLException e) {
				respuesta.localMensaje="Ha ocurrido un error "+ e;
				e.printStackTrace();
			}
			
		}
		
		try {
			statement.close();
			connection.close();
		} catch (SQLException e) {
			respuesta.localMensaje="Ha ocurrido un error "+ e;
			e.printStackTrace();
		}
		return respuesta;
	}
}
