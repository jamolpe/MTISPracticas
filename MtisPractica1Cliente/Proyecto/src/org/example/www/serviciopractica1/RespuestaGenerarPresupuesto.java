package org.example.www.serviciopractica1;

public class RespuestaGenerarPresupuesto {
	
	public GenerarPresupuesto Presupuesto;

	
	public RespuestaGenerarPresupuesto(){
		Presupuesto = new GenerarPresupuesto();
	}
	
	public GenerarPresupuestoResponse Generar(){
		
		return TrabajarBD.GenerarPresupuestoBD(Presupuesto);
	}
}
