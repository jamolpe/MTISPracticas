package org.example.www.serviciopractica1;

public class RespuestaSolicitarPresupuesto {
	SolicitarPresupuesto presupuesto;
	
	public RespuestaSolicitarPresupuesto(){
		presupuesto = new SolicitarPresupuesto();
		
	}
	
	
	public SolicitarPresupuestoResponse solicitar(){
		return TrabajarBD.SolicitarPresupuestoBD(presupuesto);
	}
}
