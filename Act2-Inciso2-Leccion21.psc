Algoritmo BuzonDeVozDepartamentos
    Definir opcion Como Entero
	
    Escribir "=== Buzón de Voz ==="
    Escribir "1. Ventas"
    Escribir "2. Recepción"
    Escribir "3. Dirección"
    Escribir "4. Compras"
    Escribir "Seleccione una opción:"
    Leer opcion
	
    Segun opcion Hacer
        1:
            Escribir "Bienvenido al departamento de Ventas"
            Escribir "Responsable: Ana López"
            Escribir "Correo: ventas@empresa.com"
        2:
            Escribir "Bienvenido al departamento de Recepción"
            Escribir "Responsable: Carlos Pérez"
            Escribir "Correo: recepcion@empresa.com"
        3:
            Escribir "Bienvenido al departamento de Dirección"
            Escribir "Responsable: María Gómez"
            Escribir "Correo: direccion@empresa.com"
        4:
            Escribir "Bienvenido al departamento de Compras"
            Escribir "Responsable: José Martínez"
            Escribir "Correo: compras@empresa.com"
        De Otro Modo:
            Escribir "Opción inválida"
    FinSegun

FinAlgoritmo