package com.wrox.begspring;


public class CalculateMultFile {
	private Operation ops = new OpMultiply();
	private ResultWriter wtr = new DataFileWriter();
	
	public static void main(String[] args) {
		CalculateMultFile calc = new CalculateMultFile();
		calc.execute(args);
	}
	


	public void execute(String [] args)  {
		long op1 = Long.parseLong(args[0]);
		long op2 = Long.parseLong(args[1]);
	   	wtr.showResult("The result of " + op1 +  
	   			ops.getOpsName() + op2 + " is "
	   			+ ops.operate(op1, op2) + "!");
		
	}

}
