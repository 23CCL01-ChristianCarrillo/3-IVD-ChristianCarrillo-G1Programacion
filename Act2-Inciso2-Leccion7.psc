Algoritmo ClasificarCalificacion
    Definir calificacion Como Real
	
    Escribir "Ingrese la calificación:"
    Leer calificacion
	
    Si calificacion < 60 Entonces
        Escribir "Deficiente"
    Sino
        Si calificacion < 70 Entonces
            Escribir "Regular"
        Sino
            Si calificacion < 80 Entonces
                Escribir "Bien"
            Sino
                Si calificacion < 90 Entonces
                    Escribir "Muy bien"
                Sino
                    Escribir "Excelente"
                FinSi
            FinSi
        FinSi
    FinSi
	
FinAlgoritmo