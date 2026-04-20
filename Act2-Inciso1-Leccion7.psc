Algoritmo BuzonDeVoz
    Definir opcion Como Entero
    Definir mensaje Como Cadena
    Definir mensajes Como Cadena
    mensajes <- ""
	
    Repetir
        Escribir "=== Buzón de Voz ==="
        Escribir "1. Dejar un mensaje"
        Escribir "2. Escuchar mensajes"
        Escribir "3. Borrar mensajes"
        Escribir "4. Salir"
        Escribir "Seleccione una opción: "
        Leer opcion
		
        Segun opcion Hacer
            1:
                Escribir "Escriba su mensaje:"
                Leer mensaje
                mensajes <- mensajes + mensaje
                Escribir "Mensaje guardado."
            2:
                Si mensajes = "" Entonces
                    Escribir "No hay mensajes."
                SiNo
                    Escribir "Mensajes guardados:"
                    Escribir mensajes
                FinSi
            3:
                mensajes <- ""
                Escribir "Todos los mensajes han sido eliminados."
            4:
                Escribir "Gracias por usar el sistema."
            De Otro Modo:
                Escribir "Opción inválida."
        FinSegun
		
    Hasta Que opcion = 4
	
FinAlgoritmo
