def main():
    torneo = []
    participantes = int(input('Ingrese un numero: '))

    if participantes > 0 and participantes <= 20:

        participantes = 2**participantes
        print(f"El numero de participantes en el torneo es de: {participantes}")
    
        for i in range(participantes):
            prueba = int(input(f'Ingrese el numero del jugador en posicion {i}: ')) # Esta linea es de prueba
            torneo.append(prueba)

        print(torneo)

    elif participantes > 20:
        print(f"El numero ingresado {participantes} es mayor que lo permitido.")
    else:
        print(f"El numero ingresado {participantes} es menor que lo permitido.")

if __name__ == '__main__':
    main()