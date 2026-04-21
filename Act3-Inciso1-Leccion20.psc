Algoritmo DiaDeLaSemana
    Definir dia Como Entero
	
    Escribir "Ingrese un número del 1 al 7:"
    Leer dia
	
    Si dia = 6 O dia = 7 Entonces
        Escribir "Fin de semana"
    Sino
        Si dia >= 1 Y dia <= 5 Entonces
            Escribir "Entre semana"
        Sino
            Escribir "Número inválido"
        FinSi
    FinSi
	
FinAlgoritmo