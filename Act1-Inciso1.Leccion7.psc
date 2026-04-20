Algoritmo  PromedioAlumno
    Definir cal1, cal2, cal3, cal4, cal5 Como Real
    Definir promedio Como Real
	
    Escribir "Ingrese la primera calificación:"
    Leer cal1
    Escribir "Ingrese la segunda calificación:"
    Leer cal2
    Escribir "Ingrese la tercera calificación:"
    Leer cal3
    Escribir "Ingrese la cuarta calificación:"
    Leer cal4
    Escribir "Ingrese la quinta calificación:"
    Leer cal5
	
    promedio <- (cal1 + cal2 + cal3 + cal4 + cal5) / 5
	
    Escribir "El promedio es: ", promedio
	
    Si promedio >= 60 Entonces
        Escribir "El alumno APRUEBA"
    SiNo
        Escribir "El alumno REPRUEBA"
    FinSi
	
FinAlgoritmo