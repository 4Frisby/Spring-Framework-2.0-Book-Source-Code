package com.wrox.begspring.aspects;

import java.util.Date;

import org.aspectj.lang.JoinPoint;
import org.aspectj.lang.annotation.Aspect;
import org.aspectj.lang.annotation.Before;

@Aspect
public class LoggingAspect {

	// intercept any method execution in the class
	@Before("execution(* com.wrox.begspring.Operation.*(..))")
	public void logMethodExecution(JoinPoint jp) {
		System.out.println( "AOP logging -> "
				+ jp.toShortString() );
	
	}
}
